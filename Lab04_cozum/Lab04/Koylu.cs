using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Koylu : Canli
    {
        // private String name feild verilir public get ve set yazması ve adi ile constructor yazması istenir
        private String name;

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

        public Koylu(String name)
        {
            Name = name;
        }

    }
}
