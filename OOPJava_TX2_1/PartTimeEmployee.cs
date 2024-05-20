using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, int paymentPerHour, int workingHours) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        private int workingHours { get; set; }

        public override int calculateSalary()//ghi đè phương thức calculateSalary() ở Employee
        {
            return workingHours * paymentPerHour; 
        }

        public override string ToString()
        {
            return base.ToString()+$" Working Hours: {workingHours} Salary = {calculateSalary()}";
        }

    }
}
