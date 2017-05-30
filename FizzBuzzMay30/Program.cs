using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMay30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a FIZZ number.");
            int FIZZ = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a BUZZ number.");
            int BUZZ = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number.");
            int Num = int.Parse(Console.ReadLine());

            for (int num = 1; num < 101; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ!!");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("FIZZ!!");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("BUZZ!!");
                }
                else
                {
                    Console.WriteLine(num);
                }

            }
        }
    }
}
