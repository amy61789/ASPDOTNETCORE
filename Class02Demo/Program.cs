using System;

namespace Class02Demo
{
    class Program
    {

        static void Main(string[] args)
        {

            double balance = 5820;
            Console.WriteLine("ATM");
            InputHandler(balance);
        }

        static public int CashCash()
        {
            try
            {
                Console.WriteLine("What would you like to do? Enter a number: ");
                Console.WriteLine("1. View your balance ");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Put in a number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Yay task complete!");
            }

            return 0;
           
        }

        static public double ViewBal(double balance)
        {
            Console.WriteLine($"Your balance is {balance}");
            InputHandler(balance);
            return balance;
        }

        static public void InputHandler(double balance)
        {

            int selection = CashCash();

            switch (selection)
            {
                case 1:
                    ViewBal(balance);
                    break;
                case 2:
                    Withdraw(balance);
                    break;
                case 3:
                    Deposit(balance);
                    break;
                default:
                    Console.WriteLine("Please choose from available options.");
                    InputHandler(balance);
                    break;
            }
        }

        static public void Withdraw(double balance)
        {
            Console.WriteLine("How much would you like to withdraw today?");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            balance -= withdrawAmount;
            //return (int)balance;
            ViewBal(balance);
            InputHandler(balance);
        }

        static public void Deposit(double balance)
        {
            Console.WriteLine("How much money would you like to deposit?");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            balance += depositAmount;
            ViewBal(balance);
            InputHandler(balance);
        }
    }
}
