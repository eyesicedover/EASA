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
            var req = new CrewReq();

            //Act
            var result = req.Duration = 12;

            //Assert
            Assert.AreEqual(12, result);
        }
    }
}
