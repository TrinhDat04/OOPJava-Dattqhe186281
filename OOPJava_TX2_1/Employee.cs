using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    public abstract class Employee : IEmployee
    {
        private String name;
        protected int paymentPerHour { get; set; }
        public Employee(String name, int paymentPerHour) { 
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public abstract int calculateSalary();

        public string getName()
        {
            return name;
        }
        public override string ToString()
        {
            return $"Name: {name} - Payment Per Hour: {paymentPerHour}";
        }
    }
}
