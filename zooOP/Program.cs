using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zooOP;

namespace zooOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kat k = new Kat();
            k.navn = "Molly";


          
            




             // create instance of  Hest
            Hest minHest = new Hest();
            Hest minAndenHest = new Hest();

            minHest.Run();
            minAndenHest.Run();
            
        } 
    }
}