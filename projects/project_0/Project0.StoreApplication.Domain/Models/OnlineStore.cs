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
      //var fileAdapter = new FileAdapter();
      String welc = "Welcome to your Online Store";
      String bags = "\nBags";
      String appa = "\nApparels";
      String clot = "\nClothes";
      String shoe = "\nShoes";

      return welc + bags + appa + clot + shoe;
    }

  }
}