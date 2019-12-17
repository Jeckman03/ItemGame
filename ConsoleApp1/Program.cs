using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Item Game");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}, are you ready to begin?", userName);
            Console.WriteLine("Hit any ket to continue...");
            Console.ReadKey();

        }
    }
}
