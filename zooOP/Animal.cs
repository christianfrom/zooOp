using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooOP
{
    // super-klassen alle dyr arver fra
    class Animal
    {
        public string navn;
        public int year;
        protected bool tam;
        protected bool farlig;
        public bool Tam
        {
            get { return tam; }
            set
            {
                if (tam == true) tam = true;
                if (tam == false) tam = value;
            }
        }

        protected bool Farlig
        {
            get { return farlig; }
            set
            {
                if (farlig == true) farlig = true;
                if (farlig == false) farlig = value;
            }
        }
    }
}
