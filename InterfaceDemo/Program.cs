using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
        // solid prensiplerinin 4. su olan interface Segratation prensibidir.
        //single responsibillity :sınıflarımızın iyi tanımlanmiş tek bir sorumluluğu olmali

        //Open-closed : sınıflarımız değişikliğe kapali ancak yeni davranışların eklenmesine açık olmalidir.

        //Liskov Substution : kodumuzda her hangi bir değişiklik yapmaya gerek kalmadan türetilmiş sınıfları yani subclasslari
        //türedikleri hata sınıfının yerine kullanabilmeliyiz

        // İnterface Segretation Genel kullanım amacli tek bir kontrat yerine daha özelleşmiş
        // birden cok kontrat oluşturmayi tercih etmeliyiz.

        //Dependency İnversion : Katmanlı mimarilerde üst seviye modüler alt seviyedeki modullere  doğrudan bağımlı olmamlıdır
        //
    {
        static void Main(string[] args)
        {

        }
    }

    interface IWorker
    {
        void Work();
        void Eat();
        void GetSalary();

    }
    interface IEat
    {
        void Eat();
    }
    interface IWork
    {
        void Work();
    }
    interface IGetSalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

}
