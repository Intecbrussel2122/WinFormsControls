using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsControls
{
    public class SeedPeople
    {

        static private List<Person> people;
        static public List<Person> People
        {
            get
            {
                return GetPeople();
            }
        }



        static private List<Person> GetPeople()
        {
            people = new List<Person>();
            var p1 = new Person() { Id = 1, FirstName = "Anass", LastName = "ElLamzi", Age = 27, IsVIP = false, Country = 1 };
            var p2 = new Person() { Id = 2, FirstName = "Florian", LastName = "Esprit", Age = 22, IsVIP = true, Country = 2 };
            var p3 = new Person() { Id = 3, FirstName = "Wouter", LastName = "Van Laere", Age = 28, IsVIP = false, Country = 3 };
            var p4 = new Person() { Id = 4, FirstName = "Olga", LastName = "Kharchuk", Age = 24, IsVIP = true, Country = 1 };
            var p5 = new Person() { Id = 5, FirstName = "Serap", LastName = "AlBayrak", Age = 28, IsVIP = false, Country = 2 };

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);
            people.Add(p5);

            return people;
        }

    }
}
