using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class FactorFactory
    {
        public long LargestPrimeFactor(long input)
        {
            long copyOfInput = input;
            int i;
            //Debug.WriteLine($"***** new run ********");
            for (i = 2; i < copyOfInput; i++)
            {
                //Debug.WriteLine($"i={i}, copyOfInput={copyOfInput}");
                if (copyOfInput % i == 0)
                {
                    copyOfInput = copyOfInput / i;
                    i--;
                }
            }

            return i;

        }

        public long[] AllPrimeFactor(long input)
        {
            long copyOfInput = input;
            long i;
            List<long> primeFactors = new List<long>();
            primeFactors.Add(input);

            for (i = 2; i < copyOfInput; i++)
            {
                if (copyOfInput % i == 0)
                {
                    primeFactors.Add(i);
                    copyOfInput = copyOfInput / i;
                    i--;
                }
            }

            primeFactors.Add(i);
            return primeFactors.ToArray();

        }

        public long[] AllFactor(long input)
        {
            long copyOfInput = input;
            long i;
            List<long> primeFactors = new List<long>();
            primeFactors.Add(input);

            for (i = 2; i < copyOfInput; i++)
            {
                if (copyOfInput % i == 0)
                {
                    primeFactors.Add(i);
                    //copyOfInput = copyOfInput / i;
                }
            }

            return primeFactors.ToArray();

        }

        public bool IsPrime(long number)
        {
            return number == LargestPrimeFactor(number);
        }


        public bool QuadPrime(long a, long b, long nMax)
        {
            bool allResultsPrime = true;
            for (int i = 0; i <= nMax; i++)
            {
                var couldBePrime = (i * i) + (a * i) + b;
                if (!IsPrime(couldBePrime))
                {
                    allResultsPrime = false;
                }
            }
            return allResultsPrime;
        }


        public long MaxQuadPrime(long a, long b)
        {
            bool allResultsPrime = true;
            long i = 0;
            while (allResultsPrime)
            {
                var couldBePrime = (i * i) + (a * i) + b;
                if (!IsPrime(couldBePrime)) break;
                i++;
            }
            return i;
        }


    }
}
