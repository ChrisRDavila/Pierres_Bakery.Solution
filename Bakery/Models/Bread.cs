using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public Bread(int _bcost)
    {
      BreadPrice = _bcost;
    }
  }
}