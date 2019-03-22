using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Canli
    {
        //Base olarak verilebilir şablonda 
        protected int can;
        protected bool canlimi;

        public Canli()
        {
            can = 100;
            canlimi = true;
        }

        public  bool Canlimi
        {
            get
            {
                return canlimi;
            }

          
        }

        public void Hasar(int hasar)
        {
            can = can - hasar;
            if (can <= 0)
                Ol();
        }
        protected virtual void Ol()
        {
            can = 0;
            canlimi = false;
        }
    }
}
