using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vragen_Variabelen_En_Operatoren_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconden;
           

            Console.WriteLine("geef hier een geheel getal");
            seconden = int.Parse(Console.ReadLine());



            int minuten = seconden / 60; ;
            int uren=0;


            do
            {
                if (seconden>=0)
                {
                    
                    if (minuten>=60)
                    {
                        uren++;
                        
                    }
                }
            } while (false);
            Console.WriteLine($"{seconden},{uren},{minuten}");
            

        }
    }

}