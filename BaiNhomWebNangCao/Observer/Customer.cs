using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Customer : IObserver
    {
        private String name;
        private int age;

        public void update(string message)
        {
            Console.WriteLine(name + " " + message);
        }


        public Customer(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
