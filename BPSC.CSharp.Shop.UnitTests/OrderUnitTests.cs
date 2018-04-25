using System;
using BPSC.CSharp.Shop.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BPSC.CSharp.Shop.UnitTests
{
    [TestClass]
    public class OrderUnitTests
    {
        [TestMethod]
        public void AmountOrderDetailTest()
        {
            // Arrange
            Item product = new Product
            {
                Name = "Klawiatura",
                UnitPrice = 30,
            };

            OrderDetail orderDetail = new OrderDetail(product, 3);

            // Fact

            decimal amount = orderDetail.Amount;

            // Asserts

            Assert.IsNotNull(orderDetail.Item);
            Assert.AreEqual("Klawiatura", orderDetail.Item.Name);
            Assert.AreEqual(90, amount);


        }

        [TestMethod]
        public void AmountOrderDetailTest2()
        {
            // Arrange
            Item product = new Product
            {
                Name = "Klawiatura",
                UnitPrice = 100,
            };

            OrderDetail orderDetail = new OrderDetail(product, 1);

            // Fact

            decimal amount = orderDetail.Amount;

            // Asserts

            Assert.IsNotNull(orderDetail.Item);
            Assert.AreEqual("Klawiatura", orderDetail.Item.Name);
            Assert.AreEqual(100, amount);

        }

    }
       
}
