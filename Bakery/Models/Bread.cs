using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int QuantityBread { get; set; }
    private int bread_price = 0;
    public Bread(int _quantity)
    {
      QuantityBread = _quantity;
    }

    public int BreadPrice()
    {
      bread_price = QuantityBread * 5;
      return bread_price;
    }
  }
}