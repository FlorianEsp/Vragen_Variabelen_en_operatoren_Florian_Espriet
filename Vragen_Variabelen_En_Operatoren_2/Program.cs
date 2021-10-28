using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vragen_Variabelen_En_Operatoren_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum =0;
            int i=0;
            int gemiddelde = 0;
            double percentage;
         

            
            do
            {
                Console.WriteLine("behaalde punten door de student");
                number = int.Parse(Console.ReadLine());
                i++;
                sum += number;
                gemiddelde = sum / 4;
                percentage = gemiddelde*10 ;
                
               

            } while (i <4);
            Console.WriteLine($"Het gemiddelde van de student is {gemiddelde}");
            Console.WriteLine($"Het behaalde Percentage van de student {percentage}%");


        }
    }
}
