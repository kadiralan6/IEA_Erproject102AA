using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // IPerson person = new IPerson(); // new lenemezler ramde fiziksel bir karşııgı yok
            NewMethod();
           
       


            Console.ReadLine();

        }

        private static void NewMethod()
        {
            Customer customer = new Customer { Name = "Kadir" };
            CustomerManager cm = new CustomerManager();
            cm.Add(new UseMsSqlServer());
            cm.Add(new UseOracleServer());
            PersonManager pm = new PersonManager();

            Student student = new Student { Name = "KadirBABa" };

            IPerson person = new Customer { Name = "KadirBABa" }; ;
            IPerson person1 = new Student { Name = "Kadir" };
            //Polymorphisim örneği
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new UseMsSqlServer(),
            new UseOracleServer()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            //pm.Add(customer);
            //pm.Add(student);
            pm.Add(person);
            pm.Add(person1);
        }
    }
    interface IPerson //Soyut Nesne
    {
         int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get ; set ; }
        public string Surname { get; set; }
  
        public string Adress { get; set; }
    
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StudentNo { get; set; }

    }

    class PersonManager
    {
        public void Add (Customer c)
        {
            Console.WriteLine(c.Name);
        }
        public void Add(Student c)
        {
            Console.WriteLine(c.Name);
        }
        public void Add (IPerson person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
