using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()//ghi đè phương thức calculateSalary() ở Employee
        {
            return 8 * getPaymentPerHours();

        }
        public override string ToString()
        {
            return base.ToString() + $"Salary = {calculateSalary()}";
        }
    }
}
