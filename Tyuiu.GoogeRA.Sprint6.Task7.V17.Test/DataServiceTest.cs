﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoogeRA.Sprint6.Task7.V17.Lib;

namespace Tyuiu.GoogeRA.Sprint6.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int[,] matrix = {
                { 1, -8, 5, -17, -15, -11, -9, 1, 3, 19 },
            { 4, - 8,  16,  3, - 12, -3, 8, -12, 15, 16},
            {-15, -1,  10, -7,  8,   2, -20, -1,  2, -1},
            {-12, 10, -18, -11, -12, -16, -14, 16,  1, -5},
            { 5,   14, - 11, - 3,  10, - 19, -1, -12, - 5, - 20},
            { - 7, - 16, - 4,  0,   10,  4, - 3, - 7, - 7, - 17},
            { - 18, 7, - 13, - 2,  18, - 8, - 16, 15,  17,  11},
            { 7,   5,   6, - 7,  9, - 9, - 11, - 13, 19, - 4},
            {  - 5,  14, - 2, - 9,  18,  16,  20, - 14, 7,   17},
            { - 9,  8,   2,   4, - 3, - 14, 16,  17, - 9,  17}};



            int[,] res = ds.GetMatrix(matrix);
            int[,] wait = {
                { 1, -8, 5, -17, -15, -11, -9, 1, 3, 19 },
            { 4, 4,  4,  3, 4, -3, 4, 4, 15, 4},
            {-15, -1,  10, -7,  8,   2, -20, -1,  2, -1},
            {-12, 10, -18, -11, -12, -16, -14, 16,  1, -5},
            { 5,   14, - 11, - 3,  10, - 19, -1, -12, - 5, - 20},
            { - 7, - 16, - 4,  0,   10,  4, - 3, - 7, - 7, - 17},
            { - 18, 7, - 13, - 2,  18, - 8, - 16, 15,  17,  11},
            { 7,   5,   6, - 7,  9, - 9, - 11, - 13, 19, - 4},
            {  - 5,  14, - 2, - 9,  18,  16,  20, - 14, 7,   17},
            { - 9,  8,   2,   4, - 3, - 14, 16,  17, - 9,  17}};

            CollectionAssert.AreEqual(wait, res);
        }
    }
}