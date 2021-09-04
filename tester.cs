using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
  static void Main(String[] args)
  {
    int i = 4;
    double d = 4.0;
    string s = "HackerRank ";


    // Declare second integer, double, and String variables.
    int intNum;
    double doubNum;
    string stringer = "Is the best";

    // Read and save an integer, double, and String to your variables.

    intNum = int.Parse(Console.ReadLine());
    doubNum = double.Parse(Console.ReadLine());
    stringer = Console.ReadLine();



    // Print the sum of both integer variables on a new line.
    int sumInt = i + intNum;
    Console.WriteLine(sumInt);


    // Print the sum of the double variables on a new line.
    double sumDoub = d + doubNum;
    Console.WriteLine(sumDoub);


    // Concatenate and print the String variables on a new line
    Console.WriteLine(s + stringer);
    // The 's' variable above should be printed first.

  }
}