using System;
using System.Collections.Generic;

using Project0.StoreApplication.Domain.Abstracts;
namespace Project0.StoreApplication.Domain.Models
{

  public class OnlineStore : Store
  {
    public OnlineStore()
    {
      Name = "Online Store";
    }

    public String Products()
    {
      
      String mac = "Mac n C \nBags\n";
      return mac;
    }

    }
}