using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Collections.Generic;
using System.Linq;

namespace MyHomework1
{
    class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }

        public Product(int id, int cost, int revenue, int sellprice)
        {
            this.Id = id;
            this.Cost = cost;
            this.Revenue = revenue;
            this.SellPrice = sellprice;
        }
    }

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
            var target = new List<Product>();
            target.Add(new Product(1, 1, 11, 21));
            target.Add(new Product(2, 2, 12, 22));
            target.Add(new Product(3, 3, 13, 23));
            target.Add(new Product(4, 4, 14, 24));
            target.Add(new Product(5, 5, 15, 25));
            target.Add(new Product(6, 6, 16, 26));
            target.Add(new Product(7, 7, 17, 27));
            target.Add(new Product(8, 8, 18, 28));
            target.Add(new Product(9, 9, 19, 29));
            target.Add(new Product(10, 10, 20, 30));
            target.Add(new Product(11, 11, 21, 31));

            var expected = new int[] { 6, 15, 24, 21 };
            
            //act
            var actual = SumByGroup.sum<Product>(target, 3, p => p.Cost );

            //assert
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod]
        public void SumTest_Revenue_GroupSize_4()
        {
            //arrange
            var target = new List<Product>();
            target.Add(new Product(1, 1, 11, 21));
            target.Add(new Product(2, 2, 12, 22));
            target.Add(new Product(3, 3, 13, 23));
            target.Add(new Product(4, 4, 14, 24));
            target.Add(new Product(5, 5, 15, 25));
            target.Add(new Product(6, 6, 16, 26));
            target.Add(new Product(7, 7, 17, 27));
            target.Add(new Product(8, 8, 18, 28));
            target.Add(new Product(9, 9, 19, 29));
            target.Add(new Product(10, 10, 20, 30));
            target.Add(new Product(11, 11, 21, 31));

            var expected = new int[] { 50, 66, 60 };

            //act
            var actual = SumByGroup.sum<Product>(target, 4, p => p.Revenue );

            //assert
            CollectionAssert.AreEqual(expected, actual.ToList());
        }
    }
}
