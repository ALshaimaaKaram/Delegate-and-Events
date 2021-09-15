using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Events
{
    class Employee
    {
        public event Action<float> DecreaseBudget;
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public void IncreaseSalary(float amount)
        {
            Salary += amount;
            if (DecreaseBudget != null)
            {
                DecreaseBudget(amount);
            }
        }

        public override string ToString()
        {
            return $"The ID is {ID}, The Name is {Name}, The Salary is {Salary}";
        }
    }
}
