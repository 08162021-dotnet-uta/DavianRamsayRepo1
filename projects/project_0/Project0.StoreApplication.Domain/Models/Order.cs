using System;

namespace Project0.StoreApplication.Domain.Models
{


  public class Order
  {
    public Store Store { get; set; }
    public Product Product { get; set; }
    public static DateTime Now { get; }
    DateTime utcDate = DateTime.UtcNow;



    public override string ToString()
    {
      return "Location: " + Store + "       Product: " + Product + "      Date Purchased: " + utcDate;
    }



  }
}