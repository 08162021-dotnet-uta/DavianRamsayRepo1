//using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;
using Project0.StoreApplication.Client.Singletons;
using System;

namespace Project0.StoreApplication.Client
{
  class Program
  {
    private static readonly CustomerSingleton _custSing = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSing = StoreSingleton.Instance;

    private static readonly ProductSingleton _productSing = ProductSingleton.Instance;
    static void Main(string[] args)
    {
      //Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();



      //var p = new Program();
      Run();

      //p.PrintAllStoreLocations();

      //System.Console.WriteLine(p.SelectAStore());
    }
    static void Run()
    {
      //ViewCustomers();
      //ViewStores();
      //ViewProducts();
      SelectStore();
    }

    static void ViewCustomers()
    {
      foreach (var cust in _custSing.Customer)
      {
        System.Console.WriteLine(cust);
      }

    }
    static void ViewStores()
    {
      foreach (var store in _storeSing.Store)
      {
        System.Console.WriteLine(store);
      }
    }

    static void ViewProducts()
    {
      foreach (var product in _productSing.Product)
      {
        System.Console.WriteLine(product);
      }
    }

    private static void output<T>(List<T> data) where T : class
    {
      var select = 0;
      //select++;
      foreach (var item in data)
      {
        Console.WriteLine(++select + "__" + item);

      }
    }

    static int SelectStore()
    {
      var d = _storeSing.Store;
      output(d);
      Console.WriteLine("Select A Store: ");
      int selected = int.Parse(Console.ReadLine());
      //Console.WriteLine();
      return (selected - 1);






      // var select = _storeSing.Store;
      // output.WriteLine("Please select a Store");
      // var option = int.Parse(Console.ReadLine());
      // var store = select[option - 1];

      // return store;

    }


    // void PrintAllStoreLocations()
    // {
    //   Levels of monitoring we can do are: 
    //   Verbose
    //   Debug
    //   Information
    //   Warning
    //   Error
    //   Fatal
    //   Log.Information("in PrintAllstoreLocations Method");
    //   var storeRepository = new StoreRepository();
    //   int i = 1;

    //   foreach (var store in storeRepository.Stores)
    //   {
    //     System.Console.WriteLine(i + " - " + store);
    //     i += 1;
    //   }
    // }

    // Store SelectAStore()
    // {

    //   Log.Information("In SelectAStore method");
    //   var sr = new StoreRepository().Stores;

    //   Console.WriteLine("Select a Store: ");

    //   var option = int.Parse(Console.ReadLine());
    //   var store = sr[option - 1];




    //   if (option == 1)
    //   {

    //     OnlineStore ol = new OnlineStore();
    //     String prods = ol.Products();

    //     Console.WriteLine(prods);
    //   }

    //   else if (option == 2)
    //   { Console.WriteLine(store); }
    //   else if (option == 3)
    //   { Console.WriteLine(store); }
    //   else
    //   { Console.WriteLine("Please select a valid option"); }

    //   //Console.WriteLine("You have Selected: ");

    //   return null;


    // }


  }
}