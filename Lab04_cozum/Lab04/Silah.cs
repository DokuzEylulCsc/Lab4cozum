using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Silah
    {
        //private saldiriGücü veri cons ve sadece public get
        private int saldiriGücü;
        public Silah(int saldiriGücü)
        {
            this.saldiriGücü = saldiriGücü;
        }
        public int SaldiriGücü
        {
            get
            {
                return saldiriGücü;
            }   
        }
    }
}
