using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSort;

namespace BubbleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BubbleSortAscOfRowSumTest()
        {
            //arrange
            int[][] array = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{7,11,13},
                new int[]{1,7,9,3,0},
                new int[]{0,1,1}
            };
            int[][] expected = new int[][]
            {
                new int[]{0,1,1},
                new int[]{1,2,3,4},
                new int[]{1,7,9,3,0},
                new int[]{7,11,13}
            };
            //act
            Bubble.BubbleSortAscOfRowSum(array);
            //assert
            Assert.AreEqual(expected.ToString(),array.ToString());
        }

        [TestMethod]
        public void BubbleSortDecOfRowSumTest()
        {
            //arrange
            int[][] array = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{7,11,13},
                new int[]{1,7,9,3,0},
                new int[]{0,1,1}
            };
            int[][] expected = new int[][]
            {
                new int[]{7,11,13},
                new int[]{1,7,9,3,0},
                new int[]{1,2,3,4},
                new int[]{0,1,1}
            };
            //act
            Bubble.BubbleSortDecOfRowSum(array);
            //assert
            Assert.AreEqual(expected.ToString(), array.ToString());
        }

        [TestMethod]
        public void BubbleSortAscMaxElTest()
        {
            //arrange
            int[][] array = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{7,11,13},
                new int[]{1,7,9,3,0},
                new int[]{0,1,1}
            };
            int[][] expected = new int[][]
            {
                new int[]{0,1,1},
                new int[]{1,2,3,4},
                new int[]{1,7,9,3,0},
                new int[]{7,11,13}
            };
            //act
            Bubble.BubbleSortAscMaxEl(array);
            //assert
            Assert.AreEqual(expected.ToString(), array.ToString());
        }

        [TestMethod]
        public void BubbleSortDecMaxElTest()
        {
            //arrange
            int[][] array = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{7,11,13},
                new int[]{1,7,9,3,0},
                new int[]{0,1,1}
            };
            int[][] expected = new int[][]
            {
                new int[]{7,11,13},
                new int[]{1,7,9,3,0},
                new int[]{1,2,3,4},
                new int[]{0,1,1} 
            };
            //act
            Bubble.BubbleSortDecMaxEl(array);
            //assert
            Assert.AreEqual(expected.ToString(), array.ToString());
        }

        [TestMethod]
        public void BubbleSortAscMinElTest()
        {
            //arrange
            int[][] array = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{7,11,13},
                new int[]{1,7,9,3,0},
                new int[]{0,1,1}
            };
            int[][] expected = new int[][]
            {
                new int[]{0,1,1},
                new int[]{1,2,3,4},
                new int[]{1,7,9,3,0},
                new int[]{7,11,13}
            };
            //act
            Bubble.BubbleSortAscMinEl(array);
            //assert
            Assert.AreEqual(expected.ToString(), array.ToString());
        }

        [TestMethod]
        public void BubbleSortDecMinElTest()
        {
            //arrange
            int[][] array = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{7,11,13},
                new int[]{1,7,9,3,0},
                new int[]{0,1,1}
            };
            int[][] expected = new int[][]
            {
                new int[]{7,11,13},
                new int[]{1,2,3,4},
                new int[]{1,7,9,3,0},
                new int[]{ 0, 1, 1 }
            };
            //act
            Bubble.BubbleSortDecMinEl(array);
            //assert
            Assert.AreEqual(expected.ToString(), array.ToString());
        }
    }
}
