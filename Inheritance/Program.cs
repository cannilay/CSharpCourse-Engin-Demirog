using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Kalıtım - Miras


    //interface mi kullanmalıyım inheritance mı
    //interface ler intheritance mantığı ile kullanılabildiği için interface ler daha mantıklıdır
    //abstruck classlar için inheritance ve interface lerin kullanımları ayrı ayrı önemlidir



    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Engin"},
                new Student{FirstName="Derin"},
                new Person{FirstName="Salih"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Person2 //bir nesneyi bir kere inheritance alabilirsiniz -- Interface olsaydı yan yana bir sürü IPerson IPerson2 yazılabilidi
    {
        //classların tek başına bir anlamı vardır ama interfacelerin yoktur
    }
    class Customer : Person
    {
        public string City { get; set; }

    }
    class Student : Person
    {
        public string Department { get; set; }

    }

}
