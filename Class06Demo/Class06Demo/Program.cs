using System;

namespace Class06Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Compact amysCar = new Compact();

            //Robot bender = new Robot();
            //amysCar.Drive(bender);

            //IDrive c3po = new Robot();
            //c3po.StartCar();
            //amysCar.Drive(c3po);

            Cyborg amy = new Cyborg();
            amysCar.Drive(amy);
        }
    }
}
