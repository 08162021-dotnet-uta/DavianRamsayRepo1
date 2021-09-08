using System;

namespace _6_FlowControl
{
  public class Program
  {
    public static string uName { get; set; }
    public static string uPwd { get; set; }
    static void Main(string[] args)
    {
    }

    /// <summary>
    /// This method gets a valid temperature between -40 and 135 inclusive 
    /// and returns the valid int. 
    /// </summary>
    /// <returns></returns>
    public static int GetValidTemperature()
    {
      string input;
      bool flag = true;
      int validInput = -50;

      while (flag)
      {
        input = Console.ReadLine();
        if (int.TryParse(input, out validInput))
        {
          if (validInput >= -40 && validInput <= 135)
          {
            flag = false;
          }
        }
      }

      return validInput;


      //throw new NotImplementedException($"GetValidTemperature() has not been implemented.");
    }

    /// <summary>
    /// This method has one int parameter
    /// It prints outdoor activity advice and temperature opinion to the console 
    /// based on 20 degree increments starting at -20 and ending at 135 
    /// n < -20, Console.Write("hella cold");
    /// -20 <= n < 0, Console.Write("pretty cold");
    ///  0 <= n < 20, Console.Write("cold");
    /// 20 <= n < 40, Console.Write("thawed out");
    /// 40 <= n < 60, Console.Write("feels like Autumn");
    /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
    /// 80 <= n < 90, Console.Write("niiice");
    /// 90 <= n < 100, Console.Write("hella hot");
    /// 100 <= n < 135, Console.Write("hottest");
    /// </summary>
    /// <param name="temp"></param>
    public static void GiveActivityAdvice(int temp)
    {
      // Console.WriteLine("Enter a number for the weather condion today");
      // temp = int.Parse(Console.ReadLine());

      if (temp < -20)//good
      {
        Console.Write("hella cold");
      }
      else if (-20 <= temp && temp < 0)//good
      {
        Console.Write("pretty cold");
      }
      else if (0 <= temp && temp < 20)
      {
        Console.Write("cold");
      }
      else if (20 <= temp && temp < 40)
      {
        Console.Write("thawed out");
      }
      else if (40 <= temp && temp < 60)
      {
        Console.Write("feels like Autumn");
      }
      else if (60 <= temp && temp < 80)
      {
        Console.Write("perfect outdoor workout temperature");
      }
      else if (80 <= temp && temp < 90)
      {
        Console.Write("niiice");
      }
      else if (90 <= temp && temp < 100)
      {
        Console.Write("hella hot");
      }
      else if (100 <= temp && temp < 135)
      {
        Console.Write("hottest");
      }









      //throw new NotImplementedException($"GiveActivityAdvice() has not been implemented.");
    }

    /// <summary>
    /// This method gets a username and password from the user
    /// and stores that data in the global variables of the 
    /// names in the method.
    /// </summary>
    public static void Register()
    {
      Console.WriteLine("Please enter a username");
      uName = Console.ReadLine();
      Console.WriteLine("Username saved");

      Console.WriteLine("Please enter a password");
      uPwd = Console.ReadLine();
      Console.WriteLine("Password saved");






      //throw new NotImplementedException($"Register() has not been implemented.");
    }

    /// <summary>
    /// This method gets username and password from the user and
    /// compares them with the username and password names provided in Register().
    /// If the password and username match, the method returns true. 
    /// If they do not match, the user is reprompted for the username and password
    /// until the exact matches are inputted.
    /// </summary>
    /// <returns></returns>
    public static bool Login()
    {
      string user;
      string pwd;
      do
      {
        Console.WriteLine("Please enter a username");
        user = Console.ReadLine();

        Console.WriteLine("Please enter a password");
        pwd = Console.ReadLine();
      }
      while (uName != user && uPwd != pwd);

      return true;





      //throw new NotImplementedException($"Login() has not been implemented.");
    }

    /// <summary>
    /// This method has one int parameter.
    /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
    /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
    /// or > 78, Console.WriteLine($"{temp} is too hot!");
    /// For each temperature range, a different advice is given. 
    /// </summary>
    /// <param name="temp"></param>
    public static void GetTemperatureTernary(int temp)
    {
      if (temp <= 42)
      {
        Console.WriteLine($"{temp} is too cold!");
      }
      else if (temp >= 43 && temp <= 78)
      {
        Console.WriteLine($"{temp} is an ok temperature");
      }
      else
      {
        Console.WriteLine($"{temp} is too hot!");
      }



      //throw new NotImplementedException($"GetTemperatureTernary() has not been implemented.");
    }
  }//EoP
}//EoN
