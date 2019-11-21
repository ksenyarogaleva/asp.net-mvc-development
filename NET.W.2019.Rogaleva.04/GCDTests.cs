using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreatCommonDivisor;

namespace GCDTests
{
    [TestClass]
    public class GCDTests
    {
        [TestMethod]
        public void EuclideanAlgorythm_0and10_10expected()
        {
            //arrange
            int a = 0;
            int b = 10;
            int expected = 10;
            //act
            int actual = GCD.EuclideanAlgorythm(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclideanAlgorythm_10and300and65_5expected()
        {
            //arrange
            int a = 10;
            int b = 300;
            int c = 65;
            int expected = 5;
            //act
            int actual = GCD.EuclideanAlgorythm(a, b,c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclideanAlgorythm_minus20and630_20expected()
        {
            //arrange
            int a = -20;
            int b = 640;
            int expected = 20;
            //act
            int actual = GCD.EuclideanAlgorythm(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclideanAlgorythm_minus39andminus13andminus169_13expected()
        {
            //arrange
            int a = -39;
            int b =-13;
            int c = -169;
            int expected = 13;
            //act
            int actual = GCD.EuclideanAlgorythm(a, b,c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinAlgorythm_0and10_10expected()
        {
            //arrange
            int a = 0;
            int b = 10;
            int expected = 10;
            //act
            int actual = GCD.SteinAlgorythm(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinAlgorythm_10and300and65_5expected()
        {
            //arrange
            int a = 10;
            int b = 300;
            int c = 65;
            int expected = 5;
            //act
            int actual = GCD.SteinAlgorythm(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinAlgorythm_minus20and630_20expected()
        {
            //arrange
            int a = -20;
            int b = 640;
            int expected = 20;
            //act
            int actual = GCD.SteinAlgorythm(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinAlgorythm_minus39andminus13andminus169_13expected()
        {
            //arrange
            int a = -39;
            int b = -13;
            int c = -169;
            int expected = 13;
            //act
            int actual = GCD.SteinAlgorythm(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
