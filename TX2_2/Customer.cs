using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX2_2
{
    public class Customer : Person
    {
        private int balance;
        public Customer(string name, string address, int balance) : base(name, address)
        {
            this.balance = balance;
        }
        public int getBalance() { return balance; }
        public override void display()
        {
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
