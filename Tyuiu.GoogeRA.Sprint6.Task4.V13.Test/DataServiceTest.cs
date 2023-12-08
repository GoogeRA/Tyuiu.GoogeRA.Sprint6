using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint6.Task4.V13.Lib;

namespace Tyuiu.GoogeRA.Sprint6.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            CollectionAssert.AreEqual(new double[] { -9.1, 1.55, 292.78, -0.57, -0.35, 0, 4.35, 4.57, -288.78, 2.45, 13.1 }, service.GetMassFunction(-5, 5));
        }
    }
}
