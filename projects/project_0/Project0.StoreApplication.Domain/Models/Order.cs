using System;

namespace Project0.StoreApplication.Domain.Models
{


  public class Order
  {
    public Store Store { get; set; }
    public Product Product { get; set; }



    public override string ToString()
    {
      return "Location: " + Store + "  Product: " + Product;
    }



  }
}