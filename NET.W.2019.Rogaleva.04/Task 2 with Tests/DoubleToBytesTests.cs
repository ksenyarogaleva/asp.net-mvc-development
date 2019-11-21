using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2019.Rogaleva._04;


namespace NET.W._2019.Rogaleva._04.Tests
{
    [TestClass()]
    public class DoubleToBytesTests
    {
        [TestMethod()]
        public void DoubleToBytesConverterTest_negative255point255()
        {
            //arrange
            double number = -255.255;
            string expected = "1100000001101111111010000010100011110101110000101000111101011100";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_255point255()
        {
            //arrange
            double number = 255.255;
            string expected = "0100000001101111111010000010100011110101110000101000111101011100";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_4294967295()
        {
            //arrange
            double number = 4294967295.0;
            string expected = "0100000111101111111111111111111111111111111000000000000000000000";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_minvalue()
        {
            //arrange
            double number = double.MinValue;
            string expected = "1111111111101111111111111111111111111111111111111111111111111111";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_maxvalue()
        {
            //arrange
            double number = double.MaxValue;
            string expected = "0111111111101111111111111111111111111111111111111111111111111111";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_epsilon()
        {
            //arrange
            double number = double.Epsilon;
            string expected = "0000000000000000000000000000000000000000000000000000000000000001";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_NaN()
        {
            //arrange
            double number = double.NaN;
            string expected = "1111111111111000000000000000000000000000000000000000000000000000";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_negativeInfinity()
        {
            //arrange
            double number = double.NegativeInfinity;
            string expected = "1111111111110000000000000000000000000000000000000000000000000000";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void DoubleToBytesConverterTest_positiveInfinity()
        {
            //arrange
            double number = double.PositiveInfinity;
            string expected = "0111111111110000000000000000000000000000000000000000000000000000";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_negativenull()
        {
            //arrange
            double number = -0.0;
            string expected = "1000000000000000000000000000000000000000000000000000000000000000";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DoubleToBytesConverterTest_positivenull()
        {
            //arrange
            double number = 0.0;
            string expected = "0000000000000000000000000000000000000000000000000000000000000000";
            //act
            string actual = DoubleToBytes.DoubleToBytesConverter(number);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}