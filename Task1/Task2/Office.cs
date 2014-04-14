using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Office
    {
        private event GreetingsHandler _employeeIncome;
        private event GoodbuyHandler _employeeLeave;

        List<Person> presentPersons = new List<Person>();

        public void Income(Person employee,Time time)
        {
            if (_employeeIncome!=null)
            {
                _employeeIncome(employee.Name, time);    
            }
            _employeeIncome += employee.Greetings;
            _employeeLeave += employee.Goodbuy;
            presentPersons.Add(employee);
        }
        public void Leave(Person employee)
        {
            _employeeLeave -= employee.Goodbuy;
            if (_employeeLeave != null)
            {
                _employeeLeave(employee.Name);
                _employeeIncome -= employee.Greetings;
            }
            presentPersons.Remove(employee);
        }
    }
}
