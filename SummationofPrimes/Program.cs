using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

/*
Summation of primes

The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*/

/*
isPrime number sum 142913828922.
Time elapsed: 00:10:12.4876617

isPrime number sum 142913828922.
Time elapsed: 00:10:13.0506744

 * -----------

isPrime2 number sum 142913828922
Time elapsed: 00:05:07.1510642

isPrime2 number sum 142913828922.
Time elapsed: 00:05:07.3628446
 
*/
namespace SummationofPrimes
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            HashSet<long> primeNumber = new HashSet<long>();

            //for (int i = 1; i < 2000000; i++)
            for (int i = 1; i < 10; i++)
            {
                // if (isPrime(i))
                if (isPrime2(i))
                {
                    //Console.WriteLine("{0}", i);
                    primeNumber.Add(i);
                }
            }

            Console.WriteLine("isPrime2 number sum {0}.", primeNumber.Sum() );
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            
        }

        private static bool isPrime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            if (i == number)
            {
                return true;
            }
            return false;
        }


        private static bool isPrime2(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false; //Even number     

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

    }
}
