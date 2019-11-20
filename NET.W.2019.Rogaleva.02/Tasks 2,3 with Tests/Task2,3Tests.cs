using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;
using System;


namespace Tasks.Tests
{
    [TestClass()]
    public class Task2Tests
    {
        [TestMethod()]
        public void FindNextBiggerNumber_12_21returned()
        {
            //add
            int testNumber = 12;
            int expected = 21;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_513_531returned()
        {
            //arrange
            int testNumber = 513;
            int expected = 531;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_2017_2071returned()
        {
            //arrange
            int testNumber = 2017;
            int expected = 2071;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_414_441returned()
        {
            //arrange
            int testNumber = 414;
            int expected = 441;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_144_414returned()
        {
            //arrange
            int testNumber = 144;
            int expected = 414;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_1234321_1241233returned()
        {
            //arrange
            int testNumber = 1234321;
            int expected = 1241233;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_1234126_1234162returned()
        {
            //arrange
            int testNumber = 1234126;
            int expected = 1234162;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_3456432_3462345returned()
        {
            //arrange
            int testNumber = 3456432;
            int expected = 3462345;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_10_nullreturned()
        {
            //arrange
            int testNumber = 10;
            int expected = -1;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNextBiggerNumber_20_nullreturned()
        {
            //arrange
            int testNumber = 20;
            int expected = -1;
            //act
            int actual = Task2.FindNextBiggerNumber(testNumber);
            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
