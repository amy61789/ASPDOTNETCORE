using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo
{
    interface IPerson
    {
        string Name { get; set; }
        void Eat();
        void Sleep();
        bool DrinkCoffee();
    }
}
