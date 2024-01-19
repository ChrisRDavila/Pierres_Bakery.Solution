namespace Bakery.Models
{
  public class Pastry
  {
    public int QuantityPastry { get; set; }
    public Pastry(int _quantity)
    {
      QuantityPastry = _quantity;
    }
  }
}