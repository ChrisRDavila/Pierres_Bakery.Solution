using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod]
    public void GetPastryQuantity_ReturnsPastryOrder_Int()
    {
      //Arrange
      int pastry_quantity = 2;
      Pastry testPastry = new Pastry(pastry_quantity);
      //Act
      int result = testPastry.QuantityPastry;
      //Assert
      Assert.AreEqual(pastry_quantity, result);
    }

    [TestMethod]
    public void SetQuantityPastry_SetValueOfPastryOrder_Void()
    {
      //Arrange
      Pastry testOrder = new Pastry(5);
      int newQuantity = 12;
      //Act
      testOrder.QuantityPastry = newQuantity;
      //Assert
      Assert.AreEqual(newQuantity, testOrder.QuantityPastry);
    }

    [TestMethod]
    public void GetPastryUnitPrice_ReturnPastryUnitPrice_Int()
    {
      //Arrange
      int test_quantity = 3;
      Pastry testOrder = new Pastry(test_quantity);
      int expect_price = 6;
      //Act
      int result = testOrder.PastryPrice();
      //Assert
      Assert.AreEqual(expect_price, result);
    }

    [TestMethod]
    public void PastryQuantityDivisibleByFour_ReturnPriceWithDiscount_Int()
    {
      //Arrange
      int test_quantity = 12;
      Pastry testOrder = new Pastry(test_quantity);
      int expected_total = 18;
      //Act
      int result = testOrder.PastryPrice();
      //Assert
      Assert.AreEqual(expected_total, result);
    }

    [TestMethod]
    public void PastryQuantityWhenRemainderThree_ReturnPriceWithDiscount_Int()
    {
      //Arrange
      int test_quantity = 13;
      Pastry testOrder = new Pastry(test_quantity);
      int expected_total = 20;
      //Act
      int result = testOrder.PastryPrice();
      //Assert
      Assert.AreEqual(expected_total, result);
    }

    [TestMethod]
      public void PastryQuantityWhenRemainderTwo_ReturnPriceWithDiscount_Int()
    {
      //Arrange
      int test_quantity = 18;
      Pastry testOrder = new Pastry(test_quantity);
      int expected_total = 28;
      //Act
      int result = testOrder.PastryPrice();
      //Assert
      Assert.AreEqual(expected_total, result);
    }

    [TestMethod]
      public void PastryQuantityWhenRemainderOne_ReturnPriceWithDiscount_Int()
    {
      //Arrange
      int test_quantity = 7;
      Pastry testOrder = new Pastry(test_quantity);
      int expected_total = 12;
      //Act
      int result = testOrder.PastryPrice();
      //Assert
      Assert.AreEqual(expected_total, result);
    }
    
  }
}

//check math for pastry
// 1 2 3 4    5 6  7  8     9 10 11 12    13 14 15 16    17 18 19 20
// 2 4 6 free 8 10 12 free  14 16 18 free 20 22 24 free  26 28 30 free