using System;
using Bakery.Models;
using Bakery.UserInterfaceModels;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
      Console.Write(WelcomeBanner.Welcome);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Hello and Welcome to Pierres Bakery app!");
      Console.WriteLine("\nWe Specialize in two items: \n\nBread @ 5$ each \nPastry @ 2$ each");
      Console.WriteLine("\nWere currently running a deal on both: \nBuy Two Loaves of Bread, get One Free \nBuy Three Pastries, Get One Free ");
      Console.WriteLine("\nWould You Like to purchase some Bread, Pastries or Both?");
      Console.WriteLine("\nIf both please enter 'both', if just bread please enter 'bread', if just pastries please enter 'pastry':");
      string orderAnswer = Console.ReadLine();
      if(orderAnswer == "both" || orderAnswer == "Both" || orderAnswer == "BOTH")
      {
        OrderInput();
      } else if (orderAnswer == "pastry" || orderAnswer == "Pastry" || orderAnswer == "PASTRY")
      {
        JustPastry();
      }
      else if (orderAnswer == "bread" || orderAnswer == "Bread" || orderAnswer == "BREAD")
      {
        JustBread();
      }
      else
      {
        Console.WriteLine("Please enter a valid response");
        Main();
      }
    }
    static void OrderInput()
      {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("\nYouve chosen to order both Bread and Pastries!");
      Console.WriteLine(BannerBread.Image);
      Console.WriteLine("\nHow many loaves of bread would you like to purchase?");
      Console.WriteLine("\nPlease enter a positive whole number for your bread order:");
      int _bquantity = int.Parse(Console.ReadLine());
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine(BannerPastry.Image);
      Console.WriteLine("\nHow many pastries would you like to purchase?");
      Console.WriteLine("\nPlease enter a positive whole number for your pastry order:");
      int _pquantity = int.Parse(Console.ReadLine());
      Console.Write(Calculating.Sum);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Bread breadOrder = new Bread(_bquantity);
      Pastry pastryOrder = new Pastry(_pquantity);
      int breadBill = breadOrder.BreadPrice();
      int pastryBill = pastryOrder.PastryPrice();
      int totalBill = breadBill + pastryBill;
      Console.WriteLine("\nYour order total for Bread is:");
      Console.WriteLine("__________________________________");
      Console.WriteLine($" \n${breadBill}.00 dollars");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("\nYour order total for Pastries is:");
      Console.WriteLine("___________________________________");
      Console.WriteLine($"\n${pastryBill}.00 dollars");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("\nYour total for the full order is:");
      Console.WriteLine("___________________________________");
      Console.WriteLine($"\n${totalBill}.00 dollars");
      Console.WriteLine("-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-");

      Goodbye();
      }    
    static void JustPastry()
    {
      Console.WriteLine("\nWell, Im guessing you came for our other item? How many pastries would you like to purchase?");
      Console.WriteLine("\nPlease enter a positive whole number for your pastry order:");
      int _pquantity = int.Parse(Console.ReadLine());
      Console.Write(Calculating.Sum);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Pastry pastryOrder = new Pastry(_pquantity);
      int pastryBill = pastryOrder.PastryPrice();
      Console.WriteLine($"\nYour order total for Pastries is \n${pastryBill}.00 dollars");
      Console.WriteLine("\nEnjoy your meal!!!");
      Goodbye();
    }
    static void JustBread()
    {
      Console.WriteLine("\nYouve chosen to order Bread!");
      Console.WriteLine(BannerBread.Image);
      Console.WriteLine("\nHow many loaves of bread would you like to purchase?");
      Console.WriteLine("\nPlease enter a positive whole number for your bread order:");
      int _bquantity = int.Parse(Console.ReadLine());
      Console.Write(Calculating.Sum);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Bread breadOrder = new Bread(_bquantity);
      int breadBill = breadOrder.BreadPrice();
      Console.WriteLine($"\nYour order total for Bread is \n${breadBill}.00 dollars");
      Goodbye();
    }
    static void Goodbye()
    {
      Console.Write(GoodbyeBanner.Goodbye);
      Console.WriteLine("Thanks for dining with us <3<3<3");
      
    }  
  }
}
  