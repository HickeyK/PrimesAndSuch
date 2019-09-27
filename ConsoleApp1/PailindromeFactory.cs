using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  struct PalindromicProduct
    {
        public long i;
        public long j;
        public long value;
    }

    public class PailindromeFactory
    {

        public List<PalindromicProduct> GetPalindromicProducts()
        {
            int iterCount = 0;
            var palindromicProducts = new List<PalindromicProduct>();
            for (int i = 100; i < 1000; i++)
            {
                for (int j = i; j < 1000; j++)
                {
                    iterCount++;
                    long candidate = i * j;
                    if (IsPalindrome(candidate))
                        palindromicProducts.Add(new PalindromicProduct {i=i, j=j, value=candidate });
                }

            }
            Console.WriteLine($"Interation count {iterCount}");
            Console.WriteLine($"List count {palindromicProducts.Count()}");
            Console.WriteLine($"Distinct count {palindromicProducts.Select(p => p.value).Distinct().Count()}");
            return palindromicProducts;
        }

        bool IsPalindrome(long number)
        {
            string strNumber = number.ToString();
            string strReverse = new string(strNumber.ToCharArray().Reverse().ToArray());

            if (strNumber == strReverse)
                return true;

            return false;
        }

    }
}
