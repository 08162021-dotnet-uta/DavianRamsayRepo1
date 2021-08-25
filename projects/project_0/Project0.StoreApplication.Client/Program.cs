using Project0.StoreApplication.Domain.Abstracts;
using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;


namespace Project0.StoreApplication.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();



      var p = new Program();

      p.PrintAllStoreLocations();

      System.Console.WriteLine(p.SelectAStore());
    }

    void PrintAllStoreLocations()
    {
      //Levels of monitoring we can do are: 
      //Verbose
      //Debug
      //Information
      //Warning
      //Error
      //Fatal
      Log.Information("in PrintAllstoreLocations Method");
      var storeRepository = new StoreRepository();
      int i = 1;

      foreach (var store in storeRepository.Stores)
      {
        System.Console.WriteLine(i + " - " + store);
        i += 1;
      }
    }

    Store SelectAStore()
    {

      Log.Information("In SelectAStore method");
      var sr = new StoreRepository().Stores;

      Console.WriteLine("Select a Store: ");

      var option = int.Parse(Console.ReadLine());
      var store = sr[option - 1];
      
      
      
      
      if (option == 1)
       {
         
         OnlineStore ol = new OnlineStore();
         String prods;
         
         Console.WriteLine(prods = ol.Products());}

       else if (option ==2)
       {Console.WriteLine(store);}
       else if (option==3)
       {Console.WriteLine(store);}
       else
         {Console.WriteLine("Please select a valid option");}
       
       //Console.WriteLine("You have Selected: ");

       return store;
       
       
    }

   
  }
}