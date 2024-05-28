using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int number1 = 2147483647; //2147483647 max
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255; //0-255
            bool condition = false; //şart
            char character = 'A'; //harf
            string city = "Ankara";
            double number5 = 10.5;
            decimal number6 = 10.4m; //sonunda m harfi kullanılmalı
            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is : {0}", character);

            Console.WriteLine((int)Days.Friday);

            Console.ReadKey();
        }
    }

    enum Days
    {
        Monday,Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday

    }
}
