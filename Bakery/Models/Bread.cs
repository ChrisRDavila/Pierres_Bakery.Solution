using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public Bread(int bread_cost)
    {
      BreadPrice = bread_cost;
    }
  }
}