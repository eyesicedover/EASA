using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EASA.Models;

namespace EASA.Tests
{
    [TestClass]
    public class DistanceTests
    {
        [TestMethod]
        public void DoesDistanceCalc_ReturnDistanceCalc_Double()
        {
            //Arrange
            var newDistance = new Distance(28, 32, 80, 34, 28, 33, 80, 34);

            //Act
            var result = Math.Round(newDistance.CalcDistance(), 2);

            //Assert
            Assert.AreEqual(1.85, result);
        }

        [TestMethod]
        public void DoesConversion_ReturnDistanceInNMi_Double()
        {
            //Arrange
            var newDistance = new Distance(28, 32, 80, 34, 28, 33, 80, 34);
            var kilometers = Math.Round(newDistance.CalcDistance(), 2);

            //Act
            var result = Math.Ceiling(newDistance.ConvertNautical(kilometers));

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
