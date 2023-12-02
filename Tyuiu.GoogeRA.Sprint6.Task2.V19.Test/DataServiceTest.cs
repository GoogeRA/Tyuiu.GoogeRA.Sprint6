using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint6.Task2.V19.Lib;

namespace Tyuiu.GoogeRA.Sprint6.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] TestArray = new double[] { 1.18, -14.95, -16.13, -7.17, -1.3, 0, -5.62, -0.52, 7.63, 5.97, -10.17 };
            CollectionAssert.AreEqual(TestArray, ds.GetMassFunction(-5, 5));
        }
    }
}
