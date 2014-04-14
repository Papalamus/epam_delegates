using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Office office = new Office();
            Random r = new Random();
            Person[] testPersons =
            {
                new Person() {Name = "Irina"},
                new Person() {Name = "Pavel"},
                new Person() {Name = "Peka"},
                new Person() {Name = "Terrlo"}
            };
            foreach (Person testPerson in testPersons)
            {
                office.Income(testPerson,new Time(){Hours = r.Next(24)});
                Console.WriteLine("_____________________");
            }
            Console.WriteLine("Now leaving");
            foreach (Person testPerson in testPersons)
            {
                office.Leave(testPerson);
                Console.WriteLine("_____________________");
            }
            Console.ReadKey();
        }
    }
}
