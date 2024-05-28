using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays //diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            string[] students2 = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students3 = new[] { "Engin", "Derin", "Salih" };

            string[] students4 = { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {
                //Console.WriteLine(student);
            }

            //çok boyutlu diziler 

            string[,] regions = new string[5, 3] //türkiyede 5 bölge var ve 5 bölge için 3 şehir tanımlamak istiyorum
            {
                { "İstanbul","İzmit","Balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir","Muğla","Manisa"}
            };


            for (int i = 0; i <= regions.GetUpperBound(0); i++) //satır
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) //stun
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*******");
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
