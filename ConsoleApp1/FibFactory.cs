using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FibFactory : IEnumerable
    {
        private int[] prevTwo = {0,1};

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                yield return prevTwo.Sum();
                prevTwo = new int[] { prevTwo[1], prevTwo.Sum() };
            }
        }
    }
}
