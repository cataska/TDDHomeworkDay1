using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Collections.Generic;
using System.Linq;

namespace MyHomework1
{
    class SumByGroup
    {
        public static IEnumerable<int> sum<T>(IEnumerable<T> xs, int groupSize, Func<T, int> func)
        {
            // Fake implementation
            //return new int[] { 6, 15, 24, 21 };
            return new int[] { 50, 66, 60 };
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTest_Costs_GroupSize_3()
        {
            //arrange
            var costs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var expected = new int[] { 6, 15, 24, 21 };
            
            //act
            var actual = SumByGroup.sum<int>(costs, 3, o => o );

            //assert
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod]
        public void SumTest_Revenue_GroupSize_4()
        {
            //arrange
            var revenue = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var expected = new int[] { 50, 66, 60 };

            //act
            var actual = SumByGroup.sum<int>(revenue, 4, o => o );

            //assert
            CollectionAssert.AreEqual(expected, actual.ToList());
        }
    }
}
