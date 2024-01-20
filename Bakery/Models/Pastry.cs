namespace Bakery.Models
{
  public class Pastry
  {
    public int QuantityPastry { get; set; }
    private int pastry_price = 0;
    public Pastry(int _pquantity)
    {
      QuantityPastry = _pquantity;
    }

    public int PastryPrice()
    {
      if(QuantityPastry % 4 == 0)
      {
        pastry_price = (QuantityPastry - (QuantityPastry / 4)) * 2;
      }
      else if (QuantityPastry < 4)
      {
      pastry_price = QuantityPastry * 2;
      }
      else if ((QuantityPastry - 1) % 4 == 0)
      {
        pastry_price = ((QuantityPastry - 1) - ((QuantityPastry - 1) / 4)) * 2 + 2;
      }
      else if ((QuantityPastry - 2) % 4 == 0)
      {
        pastry_price = ((QuantityPastry - 2) - ((QuantityPastry - 2) / 4)) * 2 + 4;
      }
      else if ((QuantityPastry - 3) % 4 == 0)
      {
        pastry_price = ((QuantityPastry - 3) - ((QuantityPastry - 3) / 4)) * 2 + 6;
      }
      return pastry_price;
    }
  }
}