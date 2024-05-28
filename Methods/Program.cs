using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();

            //var result = Add2(22);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1,2,3,4,5,6,7,8));

            Console.ReadKey();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        //void git şunu yap demek
        //static int Add2(int number1, int number2=24) //add2 yi kullanan kişinin number1 ve number2 isimli iki tane değişken parametreyi buraya göndermesi lazım
        //{
        //    var result = number1 + number2;
        //    return result;
        //}
        //eğer number2 verilmezse default olarak 24 u kullan demektir

        static int Add3(out int number1, int number2) //ref int number1
        {
            number1 = 30; //ref number1 in referansını kullan demek yani sonuç 30 olur
            return number1 + number2; //out ile ref in farkı ref de bir değer atanması gerekiyor out da böyle bir şeye ihyiyaç yok
        }

        //method overloading

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        // isimi aynı ama içeriği farklı şekilde kullanabilir olması metotların overloadu

        static int Add4(int number, params int [] numbers) //params metotdumuza aynı tipte istediğimiz kadar parametre göderebileceğimiz anlamına geliyor
        {
            return numbers.Sum();
        }
        //önce bir sayı sonra params kullamını da yapabiliriz
        
        

    }
}
