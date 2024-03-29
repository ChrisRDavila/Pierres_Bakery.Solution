// using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int QuantityBread { get; set; }
    private int bread_price = 0;
    public Bread(int _bquantity)
    {
      QuantityBread = _bquantity;
    }

    public int BreadPrice()
    {
      if(QuantityBread % 3 == 0)
      {
        bread_price = (QuantityBread - (QuantityBread / 3)) * 5;
      }
      else if (QuantityBread < 3)
      {
        bread_price = QuantityBread * 5;
      }
      else
      {
        if ((QuantityBread - 1) % 3 == 0)
        {
          bread_price = (5 * (QuantityBread - 1))-((QuantityBread / 3) * 5) + 5;
        }
        else
        {
          bread_price = (5 * (QuantityBread - 2))-((QuantityBread / 3) * 5) + 10;
        }
      }
      return bread_price;
    }
  }
}