using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EASA.Models;

namespace EASA.Tests
{
    [TestClass]
    public class CrewReqTests
    {
        [TestMethod]
        public void GetDuration_ReturnsDuration_Int()
        {
            //Arrange
            var req = new CrewReq(12, 30);

            //Act
            var result = req.Duration;

            //Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void CalcAstronauts_ReturnNumAstronautsNeeded_Double()
        {
            //Arrange
            var mission = new CrewReq(48, 288);

            //Act
            var result = mission.CalcAstronauts();

            //Assert
            Assert.AreEqual(3, result);
        }
    }
}
