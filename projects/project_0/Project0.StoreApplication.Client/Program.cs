using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Serilog;
using Project0.StoreApplication.Client.Singletons;
using System;
using Project0.StoreApplication.Storage.Adapters;

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

    private const string _filepath = @"/home/davian/revature/davian_repo/data/logs.txt";

    //static I want it to be able to be available at compile time and have access to it for the lifetime of our code 
    private static string genericPath = @"/home/davian/revature/davian_repo/data/";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();


    //private Product tempProduct;  // selecting product list 
    // private Store tempStore;   // selecting store from your store list



    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_filepath).CreateLogger();


      Run();


    }
    static void Run()
    {

      //utilizing logs to know when the run method is being used by the application
      Log.Information("Initiated Run Method");


      Console.WriteLine("Orders below");
      PrintAllOrder();


      var tempStore = SelectStore();

      var tempProduct = SelectProduct();


      Console.WriteLine("The selected Store: " + tempStore);

      Console.WriteLine("The Selected Product: " + tempProduct);

      Console.WriteLine("\n\n Do you want to see the purchases for the: " + tempStore + " Store?");

      if (Confirmation())
      {
        output(GetOrdersFromStore(tempStore));
      }

      else
      {
        //Console.Write("You selected not to see your purchases");
      }



      Console.WriteLine("Do you want to confirm this purchase?");




      if (Confirmation())
      {
        var tempOrder = new Order() { Store = tempStore, Product = tempProduct };
        _orderSing.AddToOrderRepository(tempStore, tempProduct);
        AddOrdertoStore(tempStore, tempOrder);
      }
      else
      {

      }

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





    // All the methods implemented in the run



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

    /// <summary>
    /// This method takes 2 permeters Store and Order. This method stores the orders to the location of the stores and s
    /// </summary>
    /// <param name="s"></param>
    /// <param name="o"></param>
    static void AddOrdertoStore(Store s, Order o)
    {
      string ThePath = genericPath + s.Location + ".xml";
      List<Order> tempOrder;
      if (_fileAdapter.ReadFromFile<Order>(ThePath) == null)
      {
        _fileAdapter.WriteToFile<Order>(ThePath, new List<Order>());
      }
      else
      {
        tempOrder = _fileAdapter.ReadFromFile<Order>(ThePath);
        tempOrder.Add(o);
        _fileAdapter.WriteToFile<Order>(ThePath, tempOrder);
      }



    }


    /// <summary>
    /// this method has a parameter of Store, and returns a list of orders. 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    static List<Order> GetOrdersFromStore(Store s)
    {
      string ThePath = genericPath + s.Location + ".xml";

      return _fileAdapter.ReadFromFile<Order>(ThePath);
    }



    static bool Confirmation()
    {
      Console.WriteLine("Y/N");
      if (Console.ReadLine() == "Y")
      {
        return true;
      }
      else
        return false;

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

