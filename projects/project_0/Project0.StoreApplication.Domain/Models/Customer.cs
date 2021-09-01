using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project0.StoreApplication.Domain.Models
{
  // this is a comment
  /// <summary>
  /// This is an XML Commnet
  /// </summary>

  public class Customer
  {
    public byte CustomerId { get; set; }
    public string Name { get; set; }

    //[NotMapped]
    // public List<Order> Orders { get; set; }


    // public Customer()
    // {
    //   Name = "It's Monay and I am tired";
    //   Orders = new List<Order>();

    // }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }
  }
}