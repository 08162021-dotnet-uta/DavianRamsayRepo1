//using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Serilog;
using Project0.StoreApplication.Client.Singletons;
using System;
//using Project0.StoreApplication.Storage.Adapters;



namespace Project0.StoreApplication.Client
{
  class Program
  {
    // private const string path = @"/home/davian/revature/davian_repo/data/Logs";
    //private const string _path = @"/home/davian/revature/davian_repo/data/Store.xml";
    //private static readonly FileAdapter fileAdapter = new FileAdapter();


    private static readonly CustomerSingleton _custSing = CustomerSingleton.Instance;

    private static readonly StoreSingleton _storeSing = StoreSingleton.Instance;

    private static readonly ProductSingleton _productSing = ProductSingleton.Instance;

    private static OrderSingleton _orderSing = OrderSingleton.Instance;


    // private Product tempProduct;  //
    // private Store tempStore;   //



    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();




      Run();


    }
    static void Run()
    {
      //ViewCustomers();
      //ViewStores();
      //ViewProducts();

      // Console.WriteLine("Welcome Valued Customer!");
      //       Console.WriteLine("Your previous purchase are listed below.");
      //       PrintAllOrders();
      //       
      //       var tempStore = SelectStore();
      //      
      //       var tempProduct = SelectProduct();
      //     
      //       Console.WriteLine("The Selected Store is : " + tempStore);
      //      
      //       Console.WriteLine("The selected product is : " + tempProduct);
      //       

      Console.WriteLine("Orders below");
      PrintAllOrder();
      var tempStore = SelectStore();
      var tempProduct = SelectProduct();

      Console.WriteLine("The selected Store: " + tempStore);

      Console.WriteLine("The Selected Product: " + tempProduct);
      _orderSing.AddToOrderRepository(tempStore, tempProduct);

      // Console.WriteLine(SelectStore());

    }

    private static void PrintAllOrder()
    {
      int count = 0;
      foreach (var o in _orderSing.getRepo().GetOrders())
      {
        count++;
        Console.WriteLine(count + "__" + o);
      }
    }


    //implementing generics for a list of items
    private static void output<T>(List<T> data)
    {
      var select = 0;

      foreach (var item in data)
      {
        //++select;
        Console.WriteLine(++select + "__" + item);

      }
    }

    static Store SelectStore()
    {
      var d = _storeSing.Store;
      output(d);
      Console.WriteLine("Please select a Location");

      var selected = int.Parse(Console.ReadLine());

      var ret = d[selected - 1];


      return (ret);


    }



    static Product SelectProduct()
    {
      var d = _productSing.Product;
      output(d);
      Console.WriteLine("Please select a product");
      var selected = int.Parse(Console.ReadLine());
      var ret = d[selected - 1];

      return ret;
    }

    static Customer SelectCustomer()
    {
      var d = _custSing.Customer;
      output(d);
      Console.WriteLine("");


      return null;
    }


  }




  //  if (selected == 1)
  //       {
  //         Console.WriteLine("Here are your products for the: " + ret);
  //         Console.WriteLine(SelectProduct());
  //         Log.Information("Logging");

  //       }
  //       else if (selected == 2)
  //       { Console.WriteLine("Here are your products for the: " + ret); }

  //       else if (selected == 3)
  //       { Console.WriteLine("Here are your products for the: " + ret); }
  //       else
  //       {
  //         Console.WriteLine("invalid selection");

  //       }
















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


  // static void ViewCustomers()
  //     {
  //       foreach (var cust in _custSing.Customer)
  //       {
  //         System.Console.WriteLine(cust);
  //       }

  //     }
  //     static void ViewStores()
  //     {
  //       foreach (var store in _storeSing.Store)
  //       {
  //         System.Console.WriteLine(store);
  //       }
  //     }

  //     static void ViewProducts()
  //     {
  //       foreach (var product in _productSing.Product)
  //       {
  //         System.Console.WriteLine(product);
  //       }
  //     }




}

