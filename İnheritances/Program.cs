using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritances
{
    class Program
    {
        static void Main(string[] args)
        {

            //Miras alınan Class da Dahil Btün classlar kullanılabilir.
            //Her bir class bir kez miraz alabilir.
            //
            Player player = new Player();

            Coach coach = new Coach
            {
                Id = 1,
                Name = "Kadir",
                Surname = "Alan",
                CoachPosition="Head Position"
            };
            Person person = new Person();
            person.Name = "Ahmet";


            Console.WriteLine(coach.Surname);
            Console.ReadLine();
        }
    }
    class Person//Base Class
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

    }

    class Player : Person //Sub Class
    {

    }
    class Coach:Person //Sub Class
    {
        public string CoachPosition { get; set; }
    }

}
