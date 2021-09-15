using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Events
{
    class Company
    {
        public string Name { get; set; }
        public float Budget { get; set; }
        public List<Employee> employees { get; set; }

        public void decreaseBudget(float amount)
        {
            Budget -= amount;
        }

        public List<Employee> FilterEmployees(Predicate<float> predicate)
        {
            List<Employee> emp = new List<Employee>();
            foreach (Employee em in employees)
            {
                if (predicate(em.Salary))
                    emp.Add(em);
            }
            return emp;
        }

        public override string ToString()
        {
            return $"The Name is {Name}, The Budget is {Budget}";
        }
    }
}
