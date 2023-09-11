using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KorneevaEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KorneevaEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Лиза";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Лиза", res);
        }
    }
}
