using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vragen_Variabelen_En_Operatoren_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number ;
            byte number1 ;
            float number2 ;
            double dubbel ;
            string reftype ;
            char  cijfer ;
            long lang;

            Console.WriteLine("int number");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("byte number");
            number1 = byte.Parse(Console.ReadLine());

            Console.WriteLine("float number");
            number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Double variabel");
            dubbel = double.Parse(Console.ReadLine());

            Console.WriteLine("string variabel");
            reftype = Console.ReadLine();

            Console.WriteLine("Char number");
            cijfer = char.Parse(Console.ReadLine());

           





        }
    }
}
