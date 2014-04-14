using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal delegate void GreetingsHandler(string incomerName, Time time);
    internal delegate void GoodbuyHandler(string leaverName);
    
    struct Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return String.Format(
                "{0:00}:{1:00}:{2:00}",
                this.Hours, this.Minutes, this.Seconds);
        }
    }

    class Person
    {
        public string Name { get; set; }

        public void Greetings(string incomerName,Time time)
        {
            if (time.Hours<12)
            {
                Console.WriteLine("\"Good morning {0}!\"- said {1}", incomerName, Name);
            }
            else if (time.Hours > 17)
            {
                Console.WriteLine("\"Good evening {0}!\"- said {1}", incomerName, Name);
            }
            else
            {
                Console.WriteLine("\"Good afternoon  {0}!\"- said {1}", incomerName, Name);
            } 
            
            
        }

        public void Goodbuy(string leaverName)
        {
            Console.WriteLine("\"Goodbuy {0}!\"- said {1}", leaverName, Name);
        }
    }
}
