using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        //dal = Data-Access Layer
        void Add();
        void Update();
        void Delete(); //3 tane operasyon
    }

    //genelde ayrı dosyalar oluşturulur ama görebilmek için burada yazıyoruz

    class SqlServerCustomerDal : ICustomerDal //implament ettik ışıktan yardım alarak
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) //ekleme işlemini hangi veritabanına göre yapıcaz
        {

            customerDal.Add();
        }
    }
    //Polimorfizm çok biçimlilik //bir nesneyi farklı amaçlarla implamente edip o implamentasyonların belli bi kısmına ya da tamamına ulaşmaktır

}
