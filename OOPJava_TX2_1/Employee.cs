﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    public abstract class Employee : IEmployee //tạo lớp trừu tượng Employee kế thừa Inteface IEmployee
    {
        private String name;
        private int paymentPerHour { get; set; }
        public Employee(String name, int paymentPerHour) { 
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }
        
        public abstract int calculateSalary();

        public string getName()
        {
            return name;
        }
        public void setPaymentPerHours(int paymentPerHour)
        {
            this.paymentPerHour = (int) paymentPerHour;
        }

        public int getPaymentPerHours()
        {
            return paymentPerHour;
        }
        public override string ToString()
        {
            return $"Name: {name} - Payment Per Hour: {paymentPerHour}";
        }
    }
}
