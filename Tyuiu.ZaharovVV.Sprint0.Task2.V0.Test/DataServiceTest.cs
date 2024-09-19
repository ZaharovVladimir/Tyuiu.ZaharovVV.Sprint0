using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaharovVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZaharovVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Владимир";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Владимир", res);
        }
    }
}