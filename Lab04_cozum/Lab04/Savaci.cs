using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Savasci : Canli
    {
        //sadece feildler verilir cons indexer get setler ve diğer motodlar istenir.
        private Silah _silah;
        private String name;
        private static Savasci[] savascilar = new Savasci[100];
        private static int savasci_adet = 0;
        private static int canli_savasci_adet = 0;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Silah Silah
        {
            get
            {
                return _silah;
            }

            set
            {
                _silah = value;
            }
        }

        public static int Savasci_adet
        {
            get
            {
                return savasci_adet;
            }

           
        }

        public static int Canli_savasci_adet
        {
            get
            {
                return canli_savasci_adet;
            }

           
        }

        public Savasci(String name,Silah _silah):base()
        {
            Name = name;
            Silah = _silah;
            savascilar[Savasci_adet] = this;
            savasci_adet++;
            canli_savasci_adet++;
        }
       

        public Savasci this[int index]
        {
            get
            {
               
                return savascilar[index];
            }
            set
            {
                savascilar[index] = value;
            }
        }

        public void Saldir(Canli a)
        {
            a.Hasar(Silah.SaldiriGücü);
        }

        protected override void Ol()
        {
            base.Ol();
            canli_savasci_adet--;
        }
    }
}
