using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (x < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            
            if (x % 2==0)
            {
                Console.WriteLine("The number is " + x + " Even");

            }
            else
            {
                Console.WriteLine("The number is " + x + " Odd");

            }
            Console.ReadKey();

        }
    }
}
