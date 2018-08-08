using System;
using System.Collections.Generic;
using System.IO;

class Solution {
  static void Main(String[] args) {
    int i = 4;
    double d = 4.0;
    string s = "HackerRank ";

    // Declare second integer, double, and String variables.
    int j = Convert.ToInt32(Console.ReadLine());
    double y = Convert.ToDouble(Console.ReadLine());
    string c = Console.ReadLine();
    // Read and save an integer, double, and String to your variables.

    // Print the sum of both integer variables on a new line.
    Console.WriteLine(j + i);
    // Print the sum of the double variables on a new line.
    Console.WriteLine("{0:N1}", y + d);
    // Concatenate and print the String variables on a new line
    // The 's' variable above should be printed first.
    Console.WriteLine(s + c);  
  }
}
