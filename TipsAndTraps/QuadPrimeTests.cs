using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TipsAndTraps
{
    [TestClass]
    public class QuadPrimeTests
    {
        [TestMethod]
        public void QuadPrimeTest()
        {
            // Arrange
            var ff = new FactorFactory();


            // Act
            //var result = ff.QuadPrime(1, 41, 39);
            var result = ff.QuadPrime(-79, 1601, 79);


            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MaxQuadPrimeTest()
        {
            // Arrange
            var ff = new FactorFactory();


            // Act
            //var result = ff.MaxQuadPrime(1, 41);
            var result = ff.MaxQuadPrime(-79, 1601);


            // Assert
            //Assert.AreEqual(40, result);
            Assert.AreEqual(80, result);
        }



    }
}
