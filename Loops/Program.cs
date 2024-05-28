using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops //döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();

            // WhileLoop();

            // DoWhileLoop();

            // ForeachLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }

        //asalsa true değilse false döndürsün
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++) 
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        private static void ForLoop()
        {
            //for (int i = 2; i <= 100; i+=2) //veya i=i+2
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 100; i >= 0; i -= 2) //veya i=i-2 100 den 0 a
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished");
        }

        private static void WhileLoop()
        {
            int number = 100;

            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            foreach (var student in students) //dizi temelli //veri tabanında datayı gezmek için çoğunlukla kullanırız
            {
                // student = "Ahmet"; //döndüğünüz elemanların kendisini foreach içinde değiştiremiyoruz
                Console.WriteLine(student);
            }
        }
    }
}
