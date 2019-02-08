using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulating_Productivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            Console.ReadLine();
            Console.WriteLine("Hello");
            Console.WriteLine("I am an unfinished program so i cant register your name");
            Console.WriteLine("I can print the numbers from 0 to the last one you told me to");

            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Thank you for your time");
            Console.WriteLine("Now im going to be useless again");
            Console.WriteLine("Press any key to shut me down");
        }
    }
}
