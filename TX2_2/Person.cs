using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX2_2
{
    public abstract class Person
    {
        protected string name {  get; set; }
        protected string address { get; set; }

        public Person(string name, string address) {
            this.name = name;
            this.address = address;
        }
        public string getName() { return name; }
        public abstract void display();
    }
}
