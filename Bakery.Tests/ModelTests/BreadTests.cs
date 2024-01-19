using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread testBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void GetQuantityBread_ReturnOrderBread_Int()
    {
      //Arrange
      int test_quantity = 5;
      Bread testOrder = new Bread(test_quantity);
      //Act
      int result = testOrder.QuantityBread;
      //Assert
      Assert.AreEqual(test_quantity, result);
    }

    [TestMethod]
    public void SetQuantityBread_SetValueOfBreadOrder_Void()
    {
      //Arrange
      Bread testOrder = new Bread(5);
      int newQuantity = 10;
      //Act
      testOrder.QuantityBread = newQuantity;
      //Assert
      Assert.AreEqual(newQuantity, testOrder.QuantityBread);
    }

    [TestMethod]
    public void GetBreadUnitPrice_ReturnBreadUnitPrice_Int()
    {
      //Arrange
      int test_quantity = 1;
      Bread testOrder = new Bread(test_quantity);
      int expect_price = 5;
      //Act
      int result = testOrder.BreadPrice();
      //Assert
      Assert.AreEqual(expect_price, result);
    }

    [TestMethod]
    public void PriceQuantityDivisibleByThree_ReturnPriceWithDiscount_Int()
    {
      //Arrange
      int test_quantity = 3;
      Bread testOrder = new Bread(test_quantity);
      int expect_price = 10;
      //Act
      int result = testOrder.BreadPrice();
      //Assert
      Assert.AreEqual(expect_price, result);
    }

    [TestMethod]
    public void PriceQuantityWhenModuloTwo_ReturnPriceWithDiscount_Int()
    {
      //Arrange
      int test_quantity = 4;
      Bread testOrder = new Bread(test_quantity);
      int expect_price = 15;
      //Act
      int result = testOrder.BreadPrice();
      //Assert
      Assert.AreEqual(expect_price, result);
    }

  }
}