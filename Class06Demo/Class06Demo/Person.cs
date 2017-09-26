using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo
{
    class Person : IDrive , IPerson
    {
        public int Name { get; set; }

        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (IsValidAge(value))
                    Age = value;
                else
                    throw new ArgumentOutOfRangeException("value", "You are not old enough.");
            }
        }

        string IPerson.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private bool IsValidAge(int Age)
        {
            return (Age < minDriversAge);
        }

        public bool License()
        {
            Console.WriteLine("I meet the license requirements.");
            return true;
        }

        public void StartCar()
        {
            Console.WriteLine("Please ensure you have your seat belt buckled");
        }

        public void AdjustMirrors()
        {
            Console.WriteLine("Make sure you can see.");
        }

        public void StopCar()
        {
            Console.WriteLine("STOP!");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public bool DrinkCoffee()
        {
            throw new NotImplementedException();
        }

        private const int minDriversAge = 16; 
    }
}
