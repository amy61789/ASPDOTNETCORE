using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo
{
    class Cyborg : Robot, IDrive, IPerson
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AdjustMirrors()
        {
            Console.WriteLine("Robots Adjust Mirrors");
        }

        public bool DrinkCoffee()
        {
            Console.WriteLine("Robots Drink Coffee");
            return true;
        }

        public void Eat()
        {
            Console.WriteLine("Robots Eat");
        }

        public bool License()
        {
            Console.WriteLine("Robots have licenses");
            return true;
        }

        public void Sleep()
        {
            Console.WriteLine("Robots sleep");
        }

        public void StartCar()
        {
            Console.WriteLine("Robots start car.");
        }

        public void StopCar()
        {
            throw new NotImplementedException();
        }
    }
}
