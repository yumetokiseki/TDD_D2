using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDD_D2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Scenario1()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 100;
            var books = new List<Book>
            {
                new Book { Name= "第一集" , Price = 100 }
            };

            //act
            var actual = target.calculate(books, 5, 10, 20, 25);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Scenario2()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 190;
            var books = new List<Book>
            {
                new Book { Name= "第一集" , Price = 100 },
                new Book { Name= "第二集" , Price = 100 }
            };

            //act
            var actual = target.calculate(books, 5, 10, 20, 25);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Scenario3()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 270;
            var books = new List<Book>
            {
                new Book { Name= "第一集" , Price = 100 },
                new Book { Name= "第二集" , Price = 100 },
                new Book { Name= "第三集" , Price = 100 }
            };

            //act
            var actual = target.calculate(books, 5, 10, 20, 25);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Scenario4()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 320;
            var books = new List<Book>
            {
                new Book { Name= "第一集" , Price = 100 },
                new Book { Name= "第二集" , Price = 100 },
                new Book { Name= "第三集" , Price = 100 },
                new Book { Name= "第四集" , Price = 100 }
            };

            //act
            var actual = target.calculate(books, 5, 10, 20, 25);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
