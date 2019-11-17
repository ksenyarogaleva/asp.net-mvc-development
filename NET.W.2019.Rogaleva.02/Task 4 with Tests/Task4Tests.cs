using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;
using System;
using System.Collections.Generic;


namespace Tasks.Tests
{
    [TestClass()]
    public class Task4Tests
    {
        [TestMethod()]
        public void FilterDigitTest1()
        {
            //add
            List<int> testList = new List<int>() { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int testNumber = 7;
            List<int> expected = new List<int>() { 7, 70, 17 };
            //act
            List<int> actual = Task4.FilterDigit(testList, testNumber);
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        [TestMethod()]
        public void FilterDigitTest2()
        {
            //add
            List<int> testList = new List<int>() { 33, 71, 19, 32, 4, 9, 13, 8, 6, 7, 11, 91, 0 };
            int testNumber = 1;
            List<int> expected = new List<int>() { 71, 19, 13, 11, 91 };
            //act
            List<int> actual = Task4.FilterDigit(testList, testNumber);
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }
    }
}