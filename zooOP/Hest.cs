using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zooOP;

namespace zooOOP
{
    class Hest: Animal
    {
 
        //maxhastighed måles i km/t
        public double maxHastighed;


        public Hest()
        {
            Console.WriteLine("Indtast venligst hestens navn:");
            navn = Console.ReadLine();
            Console.WriteLine("Hestens fødselsår?");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor hurtig er du i km/t?");
            maxHastighed = Convert.ToDouble(Console.ReadLine());

        }

        private void Eat()
        {
            Console.WriteLine("Gnaske gnaske...");
        }

        public void Run()
        {


            if ((2018 - year) > 1)
            {
                Console.Write("Wrinske wrinske");
            }

            else
            { 
                Console.WriteLine("weeeeeiiii");

            }

            Console.WriteLine(" - med " + maxHastighed + " km/t");
            Console.WriteLine("Wrinske-hilsen " + navn);
            Console.WriteLine("Jeg er " + (2018 - year) + "år gammel");
            Eat();


            Console.ReadKey();
        }
    }
}
