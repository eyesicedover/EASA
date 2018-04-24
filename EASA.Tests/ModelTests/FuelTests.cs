using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EASA.Models;

namespace EASA.Tests
{
    [TestClass]
    public class FuelTests
    {
        [TestMethod]
        public void DoesCalcFuelWeight_ReturnFuelWeight_Double ()
        {
            //Arrange
            var newFuel = new Fuel(1000,1.4);
 
            //Act
            var result = newFuel.CalcFuelWeight();

            //Assert
            Assert.AreEqual(595, result);
          
        }
    }
}
