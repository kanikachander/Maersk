using Maersk;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestCases
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            List<Item> itemList = new List<Item>()
            {
                new Item(){ItemName = "A", Price = 50, Quantity = 1 },
                new Item(){ItemName = "B", Price = 30, Quantity = 1 },
                new Item(){ItemName = "C", Price = 20, Quantity = 1 }
            };

            //Act
            var order = new Order();
            var total = order.TotalOrderValue(itemList);

            //Assert
            Assert.Equal(100, total);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            List<Item> itemList = new List<Item>()
            {
                new Item(){ItemName = "A", Price = 50, Quantity = 5 },
                new Item(){ItemName = "B", Price = 30, Quantity = 5 },
                new Item(){ItemName = "C", Price = 20, Quantity = 1 }
            };

            //Act
            var order = new Order();
            var total = order.TotalOrderValue(itemList);

            //Assert
            Assert.Equal(370, total);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            List<Item> itemList = new List<Item>()
            {
                new Item(){ItemName = "A", Price = 50, Quantity = 3 },
                new Item(){ItemName = "B", Price = 30, Quantity = 5 },
                new Item(){ItemName = "C", Price = 20, Quantity = 1 },
                new Item(){ItemName = "D", Price = 20, Quantity = 1 }
            };

            //Act
            var order = new Order();
            var total = order.TotalOrderValue(itemList);

            //Assert
            Assert.Equal(280, total);
        }
    }
}
