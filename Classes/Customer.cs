using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field alan tanımlamak
        //public string FirstName;

        //property tanımlamak
        public int Id { get; set; } //bir müşterinin özelliklerini tutmak için kullandığımız nesnedir

        public string FirstName { get; set; }

        //kapsülleme
        //private string _firstName;
        //public string FirstName // ben müşteriyi okuduğumda önünde mr yazacak şekilde ver
        //{
        //    get { return "Mrs." + _firstName; }
        //    set { _firstName = value; }
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
