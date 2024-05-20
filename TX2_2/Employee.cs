using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TX2_2
{
    public class Employee : Person
    {
        private int salary {  get; set; }

        public int GetSalary()
        {
            return salary;
        }
        public Employee(string name, string adress, int salary) : base(name, adress)
        {
            this.salary = salary;
        }

        public override void display()
        {
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Salary: {salary}");
        }
    }
}
