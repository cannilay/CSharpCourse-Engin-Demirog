using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //classlar ne için kullanılır
            //bizim yapmak istediğimiz işlemleri gruplara ayırmak o grup üzerinden işlem yapmak
            //ve rahatlıkla o gruba ulaşmak

            CustomerManager customerManager = new CustomerManager(); //bu classın bir örneğini oluşturduk
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer(); 
            customer.Id = 1;
            customer.FirstName = "Engin"; //set
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer()
            {
                Id = 2, City = "İstanbul", FirstName="Derin", LastName="Demiroğ"
            };

            Console.WriteLine(customer2.FirstName); //get

            Console.ReadLine();
        }
    }
}
