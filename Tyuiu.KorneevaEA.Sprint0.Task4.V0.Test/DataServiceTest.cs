using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KorneevaEA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KorneevaEA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckSubtrationValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckMultiplikationValid()
        {
            Assert.AreEqual(50, DataService.Multiplikation(10, 5));
        }
        
        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
