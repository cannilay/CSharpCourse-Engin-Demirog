using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metinsel verileri tutmak için kullanılan değişkendir
            //Intro();

            string sentence = "My name is Engin Demiroğ";
            var result = sentence.Length; //cümlenin kaç karakter olduğunu döndürdük
            var result2 = sentence.Clone();
            sentence = "My name is Derin Demiroğ"; //sentence ı değiştirsek de result2 yi değiştirememiş olduk
            
            bool result3 = sentence.EndsWith("ğ"); //bu cümle ğ ile bitiyor mu //true false
            bool result4 = sentence.StartsWith("My name"); //bu cümle My name harfi ile başlıyor mu

            var result5 = sentence.IndexOf("name"); //bulamadığında -1 döndürür cümlenin içinde bulursa kaçıncı karakterde başlıyorsa sonucu döndürür
            var result6 = sentence.IndexOf(" "); //buluduğu ilk boşluğu sayar ve sonra devam etmez
            var result7 = sentence.LastIndexOf(" "); //aramaya sondan başlar

            var result8 = sentence.Insert(0,"Hello, "); //bir string ifadeye başka bir metni yerleştirmek için kullanılır
            var result9 = sentence.Substring(3,4); //metni parçalamak için kullanılır
            var result10 = sentence.ToLower(); //bütün karakterleri küçük harf yapar
            
            var result11 = sentence.ToUpper(); //bütün karakterleri büyük harf yapar
            var result12 = sentence.Replace(" ","-");//metin içerisinde belli karakterleri değiştirmek için kullanılır
            var result13 = sentence.Remove(2,5); //bir metinden belli bir indexden sonrasını atmak için kullanılır

            Console.WriteLine(result13);

            Console.ReadLine();
        }
        
        private static void Intro()
        {
            string city = "Ankara ";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
