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

        public override int calculateSalary()
        {
            return 8 * paymentPerHour;
        }
    }
}
