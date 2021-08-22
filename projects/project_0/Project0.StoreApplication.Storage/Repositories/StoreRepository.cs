using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;


namespace Project0.StoreApplication.Storage.Repositories
{

  public class StoreRepository
  {

    public List<Store> Stores { get; set; }

    public StoreRepository()
    {

      var fileAdapter = new FileAdapter();

      fileAdapter.WriteToFile(new List<Store>()
         {
         new GroceryStore(),
         new AthleticStore(),
         new OnlineStore()
         });

      /*  if (fileAdapter.ReadFromFile() == null)
       {
         fileAdapter.WriteToFile(new List<Store>()
          {
          new GroceryStore(),
          new AthleticStore(),
          new OnlineStore()
          });
       } */
      Stores = fileAdapter.ReadFromFile();
      {

      };
    }

    /*  public Store GetStore(int index)
     {
       try
       {

         return Stores[index];

       }
       catch
       {
         return null;

       }

     } */
  }
}

