using System;

namespace HelloCsharp
{
  internal class NewBaseType
  {

  }

  class Program : NewBaseType
  {

    int add(int a, int b)
    {


      return (a + b);
    }

    int subtract(int b, int c)
    {
      return (b - c);
    }

    int multiply(int d, int e)
    {
      return (d - e);
    }

    int divide(int f, int g)
    {

      return (f / g);
    }


    // Build a calculator using 5 methods: add, multiply, subtract, divide, print 
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

  }




}


