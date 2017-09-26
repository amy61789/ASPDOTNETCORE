using System;

namespace Class04Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int test = 10;
            //Party dotNet401d1 = new Party(test);
            Party miyasParty = new Party(3000, 20);

            Console.WriteLine(miyasParty.People);
            miyasParty.People = 50;

            miyasParty.PartyBudget();
            miyasParty.GetPeopleCount();

            Graduation collegeGrad = new Graduation("green", 10, "blue");

            collegeGrad.Games();
            collegeGrad.Budget = 200;
            collegeGrad.PartyBudget();

            Graduation dotNet401d1 = new Graduation("red", 15, "black");
            dotNet401d1.BadDecision();


            Console.Read();
        }
    }
}
