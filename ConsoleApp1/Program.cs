using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        const long MINVAL = 3;
        const long MAXVAL = 50;
        static void Main(string[] args)
        {
            FactorFinder();
            //PrimeFinder();
            //PalindromeFinder();
            //FindMostPrimes();
            
        }

        private static void PalindromeFinder()
        {
            var pf = new PailindromeFactory();
            var products = pf.GetPalindromicProducts();

            foreach(var pp in products.OrderByDescending(p => p.value))
            {
                Console.WriteLine($"Product of {pp.i} and {pp.j} is palindrimic. {pp.value}.");
            }
            var maxPp = products.OrderByDescending(p => p.value).FirstOrDefault();
            Console.WriteLine($"Max product is {maxPp.i} and {maxPp.j} at {maxPp.value}.");
        }

        private static void PrimeFinder()
        {
            var ff = new FactorFactory();
            long[][] primes = new long[MAXVAL - MINVAL + 1][];

            for (long i = MINVAL; i <= MAXVAL; i++)
            {

                var res = ff.AllPrimeFactor(i);
                primes[i - MINVAL] = res;

            }

            PrintResults(primes);

        }

        private static void FactorFinder()
        {
            var ff = new FactorFactory();
            long[][] primes = new long[MAXVAL - MINVAL + 1][];

            for (long i = MINVAL; i <= MAXVAL; i++)
            {

                var res = ff.AllFactor(i);
                primes[i - MINVAL] = res;

            }

            PrintResults(primes);

        }
        private static void PrintResults(long[][] primes)
        {
            for (int i = 0; i < primes.Length; i++)
            {
                for (int j = 0; j < primes[i].Length; j++)
                {
                    if (j==0)
                        Console.Write("{0:#,##0} => ", primes[i][j]);
                    else
                        Console.Write("{0}, ", primes[i][j]);
                }
                Console.WriteLine();
            }
        }

        private static bool QuadPrime(long a, long b, long n)
        {
            bool allResultsPrimes = true;
            for (int i = 0; i <= n; i++)
            {
                var couldBePrime = (n * n) + (a * n) + b;
                if (!IsPrime(couldBePrime))
                {
                    allResultsPrimes = false;
                }
            }
            return allResultsPrimes;
        }


        private static bool IsPrime(long number)
        {
            var ff = new FactorFactory();
            return ff.IsPrime(number);
        }

        private static long FindMostPrimes()
        {
            var ff = new FactorFactory();
            long numberOfPrimes;
            long mostSoFar = 0;
            int resultA;
            int resultB;
            long product = -1;

            for (int a = -999; a < 1000; a++)
            {
                for (int b = -1000; b <= 2000; b++)
                {
                    numberOfPrimes = ff.MaxQuadPrime(a, b);
                    if (numberOfPrimes > mostSoFar)
                    {
                        mostSoFar = numberOfPrimes;
                        resultA = a;
                        resultB = b;
                        product = a * b;
                    }
                }
            }

            return product;
        }

    }
}
