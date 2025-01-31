using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            Console.WriteLine("Enter number n: ");
            if (int.TryParse(Console.ReadLine(), out int numb))
            {
                try
                {
                    result = FibonacciCalculator.CalculateFibonacci(numb);
                    Console.WriteLine($"Number of Fibonacci {numb}: {result}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Enter number.");
            }
            Console.ReadKey();
        }
    }
}