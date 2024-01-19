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
    public void GetBreadPrice_ReturnPrice_Int()
    {
      //Arrange
      int breadPrice = 5;
      Bread testBread = new Bread(breadPrice);
      //Act
      int result = testBread.BreadPrice;
      //Assert
      Assert.AreEqual(breadPrice, result);
    }

    [TestMethod]
    public void SetBreadPrice_SetValueOfBreadPrice_Void()
    {
      //Arrange
      Bread testBread = new Bread(5);
      int updatedBreadPrice = 10;
      //Act
      testBread.BreadPrice = updatedBreadPrice;
      //Assert
      Assert.AreEqual(updatedBreadPrice, testBread.BreadPrice);
    }
  }
}