using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence1
{
    class Program
    {
        static int FibonacciSequence1(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; // To return the first Fibonacci number
            if (n == 1) return 1; // To return to second Fibonacci number

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Sequence: ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("{0} ", FibonacciSequence1(i));
            }

            Console.ReadKey();
        }
    }
}
