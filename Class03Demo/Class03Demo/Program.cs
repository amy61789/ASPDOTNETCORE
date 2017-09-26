using System;
using System.IO;
//using System.Text;

namespace Class03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //creates file path
                string filePath = @"C:\Users\Amy Funk\source\repos\Demo3File.txt";

                if (!File.Exists(filePath))             //file doesn't exist
                {
                    using (FileStream fs = File.Create(filePath))
                    {
                        //Using System.Text directly other than thru a using inputs text
                        
                        Byte[] myText = new System.Text.UTF8Encoding(true).GetBytes("This is my text. HI BABBY");
                        fs.Write(myText, 0, myText.Length);
                    }
                }
                else  //file does exist
                {
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        //reading a file in line by line
                        //string s = "";
                        //while ((s = sr.ReadLine()) != null)
                        //{
                        //    Console.WriteLine(s);
                        //}

                        string[] words = File.ReadAllLines(filePath);

                        int length = words.Length;
                        foreach (string line in words)
                        {
                            Console.WriteLine(line);
                        }

                        //Console.Read();
                    }
                    AddText(filePath);
                    DeleteText(filePath);
                }

            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The Directory you suggested does not exist.");
            }
        }

        static void AddText(string filePath)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.Write(Environment.NewLine);
                sw.WriteLine("More Text!");
            }
        }

        static void DeleteText(string filePath)
        {
            File.Delete(filePath);
            Console.WriteLine("Your file has been deleted.");
            Console.Read();
        }
    }
}

