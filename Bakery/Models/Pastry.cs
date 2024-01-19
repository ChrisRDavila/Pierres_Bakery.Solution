namespace Bakery.Models
{
  public class Pastry
  {
    public int QuantityPastry { get; set; }
    private int pastry_price = 0;
    public Pastry(int _quantity)
    {
      QuantityPastry = _quantity;
    }

    public int PastryPrice()
    {
      pastry_price = QuantityPastry * 2;
      return pastry_price;
    }
  }
}