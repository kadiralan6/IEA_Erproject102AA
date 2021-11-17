using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();



    }

    class UseMsSqlServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MsSql added");
        }

        public void Delete()
        {
            Console.WriteLine("MsSql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MsSql Upddated");

        }
    }
    class UseOracleServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Upddated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) //parametre olarak verdik. Constructer olarak yapacağız.
        {
            customerDal.Add();
        }
    }
}
