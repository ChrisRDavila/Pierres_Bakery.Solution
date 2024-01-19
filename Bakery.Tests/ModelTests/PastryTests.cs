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
  }
}