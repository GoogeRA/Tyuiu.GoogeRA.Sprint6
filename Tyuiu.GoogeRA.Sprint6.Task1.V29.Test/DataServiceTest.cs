using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint6.Task1.V29.Lib; 

namespace Tyuiu.GoogeRA.Sprint6.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] TestArray = new double[] { -14.43, -9.99, -6.38, -4.25, -3.24,  0,   3.84, 7.33, 10.96,  13.69,  15.69 };
            CollectionAssert.AreEqual(TestArray, ds.GetMassFunction(-5, 5));
        }
    }
}
