using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;
using System;

namespace Tasks.Tests
{
    [TestClass()]
    public class Task5Tests
    {
        [TestMethod()]
        public void FindNthRootTestCase1()
        {
            //add
            double testNumber = 1.0;
            int testDegree = 5;
            double precision = 0.0001;
            double expected = 1.0;

            //act
            double actual = Task5.FindNthRoot(testNumber, testDegree, precision);

            //assert
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod()]
        public void FindNthRootTestCase2()
        {
            //add
            double testNumber = 8.0;
            int testDegree = 3;
            double precision = 0.0001;
            double expected = 2.0;

            //act
            double actual = Task5.FindNthRoot(testNumber, testDegree, precision);

            //assert
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod()]
        public void FindNthRootTestCase3()
        {
            //add
            double testNumber = 0.001;
            int testDegree = 3;
            double precision = 0.0001;
            double expected = 0.1;

            //act
            double actual = Task5.FindNthRoot(testNumber, testDegree, precision);

            //assert
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod()]
        public void FindNthRootTestCase4()
        {
            //add
            double testNumber = 0.04100625;
            int testDegree = 4;
            double precision = 0.0001;
            double expected = 0.45;

            //act
            double actual = Task5.FindNthRoot(testNumber, testDegree, precision);

            //assert
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod()]
        public void FindNthRootTestCase5()
        {
            //add
            double testNumber = 0.0279936;
            int testDegree = 7;
            double precision = 0.0001;
            double expected = 0.6;

            //act
            double actual = Task5.FindNthRoot(testNumber, testDegree, precision);

            //assert
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod()]
        public void FindNthRootTestCase6()
        {
            //add
            double testNumber = 0.0081;
            int testDegree = 4;
            double precision = 0.1;
            double expected = 0.3;

            //act
            double actual = Task5.FindNthRoot(testNumber, testDegree, precision);

            //assert
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod()]
        public void FindNthRootTestCase7()
        {
            //add
            double testNumber = -0.008;
            int testDegree = 3;
            double precision = 0.1;
            double expected = -0.2;

            //act
            double actual = Task5.FindNthRoot(testNumber, testDegree, precision);

            //assert
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod()]
        public void FindNthRootTestCase8()
        {
            //add
            double testNumber = 0.004241979;
            int testDegree = 9;
            double precision = 0.00000001;
            double expected = 0.545;

            //act
            double actual = Task5.FindNthRoot(testNumber, testDegree, precision);

            //assert
            Assert.AreEqual(expected, actual, 1);

        }
        [TestMethod()]

        public void FindNthRootTest_ExceptionCase1()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => (Task5.FindNthRoot(8.0, 15, -0.6)));
        }

        [TestMethod()]

        public void FindNthRootTest_ExceptionCase2()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => (Task5.FindNthRoot(8.0, 15, -7)));
        }
    }
}