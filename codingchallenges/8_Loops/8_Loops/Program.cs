using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {
      /* Your code here */

    }

    /// <summary>
    /// Return the number of elements in the List<int> that are odd.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseFor(List<int> x)
    {
      int counter = 0;
      foreach (int values in x)
      {
        if (values % 2 != 0)
        {
          counter++;
          Console.WriteLine(values);


        }
      }

      return counter;




      //throw new NotImplementedException("UseFor() is not implemented yet.");
    }

    /// <summary>
    /// This method counts the even entries from the provided List<object> 
    /// and returns the total number found.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseForEach(List<object> x)
    {
      throw new NotImplementedException("UseForEach() is not implemented yet.");
    }

    /// <summary>
    /// This method counts the multiples of 4 from the provided List<int>. 
    /// Exit the loop when the integer 1234 is found.
    /// Return the total number of multiples of 4.
    /// </summary>
    /// <param name="x"></param>
    public static int UseWhile(List<int> x)
    {

      int counter = 0;
      int multiple = 0;


      while (x[multiple] != 1234)
      {
        if (x[multiple] % 4 == 0)
        {
          counter++;
          Console.WriteLine(x);

        }
        multiple++;

      }
      return counter;









      //throw new NotImplementedException("UseFor() is not implemented yet.");
    }

    /// <summary>
    /// This method will evaluate the Int Array provided and return how many of its 
    /// values are multiples of 3 and 4.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseForThreeFour(int[] x)
    {

      int counter = 0;

      foreach (int values in x)
        if (values % 3 == 0 && values % 4 == 0)
        {
          Console.WriteLine(values);
          counter++;

        }
      return counter;







      // throw new NotImplementedException("UseForThreeFour() is not implemented yet.");
    }

    /// <summary>
    /// This method takes an array of List<string>'s. 
    /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
    /// </summary>
    /// <param name="stringListArray"></param>
    /// <returns></returns>
    public static string LoopdyLoop(List<string>[] stringListArray)
    {
      string looper;

      foreach (var values in stringListArray)
      {
        stringListArray.Join(values);

      }


      return values;
      // throw new NotImplementedException("LoopdyLoop() is not implemented yet.");
    }
  }
}