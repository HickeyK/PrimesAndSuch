using ConsoleApp1;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TipsAndTraps
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetFib()
        {
            var fibFactory = new FibFactory();
            decimal total = 0;

            foreach(int i in fibFactory)
            {
                if (i > 4000000) break;
                //Debug.WriteLine(i);
                if (i % 2 == 0) total += i;
            }
            Debug.WriteLine(total);

            Assert.AreEqual(4613732, total);

        }

        [TestMethod]
        public void GetPrimeFactor()
        {
            var factorFactory = new FactorFactory();

            Assert.AreEqual(683, factorFactory.LargestPrimeFactor(2051));
        }
    }
}
