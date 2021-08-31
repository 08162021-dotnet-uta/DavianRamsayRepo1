using System;

namespace _3_DataTypeAndVariablesChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //
      //
      // Insert code here.
      //
      //
    }

    /// <summary>
    /// This method has an 'object' type parameter. 
    /// 1. Create a switch statement that evaluates for the data type of the parameter
    /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
    /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
    /// 4. For example, an 'int' data type will return ,"Data type => int",
    /// 5. A 'ulong' data type will return "Data type => ulong",
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string PrintValues(object obj)
    {
      string format = "Data type => ";
      //throw new NotImplementedException($"PrintValues() has not been implemented");
      switch (obj)
      {
        case int i:
          return format + "int";
        case String stringer:
          return format + "string";
        case ulong ulonger:
          return format + "ulong";
        case double doubler:
          return format + "double";
        case byte byter:
          return format + "byte";
        case sbyte sbyter:
          return format + "sbyte";
        case uint uinter:
          return format + "uint";
        case short shorter:
          return format + "short";
        case ushort ushorter:
          return format + "ushort";
        case float floater:
          return format + "float";
        case char charer:
          return format + "char";
        case bool booler:
          return format + "bool";
        case decimal decimaler:
          return format + "decimal";
        case long longer:
          return format + "long";
        case nint ninter:
          return format + "ninter";
      }




      throw new NotImplementedException($"PrintValues() has not been implemented");
    }

    /// <summary>
    /// THis method has a string parameter.
    /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
    /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
    /// 3. If the string cannot be converted to a integer, return 'null'. 
    /// 4. Investigate how to use '?' to make non-nullable types nullable.
    /// </summary>
    /// <param name="numString"></param>
    /// <returns></returns>
    public static int? StringToInt(string numString)
    {
      throw new NotImplementedException($"StringToInt() has not been implemented");

    }
  }// end of class
}// End of Namespace
