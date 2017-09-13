using System;

namespace Class01Demo
{
    class Program
    {
        //string x = "seventy-two";

        static void Main(string[] args)
        {
            string myMainVariable;
            myMainVariable = "This is my variable";
            Console.WriteLine("Hello World!");
            Console.WriteLine(myMainVariable);
            SayHello("Hello!");
            SayHello(72);
            //string words = Console.ReadLine();
            //Console.WriteLine(words);
            IterationStatements();
            SelectiveStatements();
            Console.Read();
            
        }

        static void SayHello(string greeting)
        {
            Console.WriteLine(string.Format("This is my greeting {0}",greeting));
            Console.WriteLine($"This is the new standard {greeting}");
        }

        static void SayHello(int greeting)
        {
            Console.WriteLine(string.Format("This is my greeting {0}", greeting));
            Console.WriteLine($"This is the new standard {greeting}");
        }

        static void IterationStatements()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int[] numberArray = new int[] { 72, 42, 21, 38 };
            foreach(int number in numberArray)
            {
                Console.WriteLine(number);
            }

            int x = 0;
            while(x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            }
            while(n < 5);
        }
        static void SelectiveStatements()
        {
            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();
            
            if (string.IsNullOrEmpty(userInput.Trim()))
            {
                Console.WriteLine("Please type a name!");
            }
            else
            {
                Console.WriteLine($"Welcome {userInput}");
            }
        }
    }
}
