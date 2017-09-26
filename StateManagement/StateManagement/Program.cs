using System;

namespace StateManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cat josie = new Cat();

            Cat belle = josie;
            GC.Collect();
        }
    }
}
