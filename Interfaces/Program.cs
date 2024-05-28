using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        //soyut nesneleri new leyemeyiz
        static void Main(string[] args)
        {

            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] //ICustomerdal türünde array tanımladık 2 elemanlı olucak dedik sql ve oracle kullandık
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal() 
            };

            foreach (var customerDal in customerDals) //elimizdeki dataya bütün veritabanlarını attık
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }
        private static void Demo()
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal()); //burda ekliyoruz değiştireceğimiz zaman new den sonrasını değiştirmek yeterlidir
        }
        private static void InterfacesIntro()
        {
            //bir temel nesne oluşturup bütün nesneleri ondan implamente etmektir
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departmant = "Computer Sciences"
            };
            personManager.Add(customer);
            personManager.Add(student);
        }
    }
    interface IPerson //I büyük Interface anlamına gelir sonra Person örn yazılır //soyut nesne
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson // somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } //ayrıca bi özellik tanımladık
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; } //ayrıca bi özellik tanımladık
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    
}
