using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo
{
    abstract class Party
    {
        public int People { get; set; }
        public string Location { get; set; }
        public string[] NameOfHosts { get; set; }
        public int Budget { get; set; }

        public Party()
        {

        }

        public Party(int numberOfPeople)
        {
            People = numberOfPeople;
        }

        public Party(int budget, int numberOfPeople)
        {
            Budget = budget;
            People = numberOfPeople;
        }

        public abstract void Theme();

        public void BadDecision()
        {
            Console.WriteLine("Don't do that, it's a bad decision.");
        }

        public void Games()
        {
            Console.WriteLine("We are playing bocce ball.");
        }

        public int PartyBudget()
        {
            int budget = Budget;
            Console.WriteLine(budget);
            return budget;
        }

        public void GetPeopleCount()
        {
            if(People == 20)
            {
                Console.WriteLine("You have a small party");

            }
            Console.WriteLine(People);
        }

        public bool RSVP()
        {
            bool returned = true;
            return returned;
        }
    }
}
