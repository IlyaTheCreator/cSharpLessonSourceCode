using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RPM 
{
  public class Program 
  {
    // TESTING
    public static void Main(string[] args) 
    {
      // creating 2 fractions 
      MyFraction num1 = new MyFraction(1, 5);
      MyFraction num2 = new MyFraction(5, 3);

      // signing to the event from the 4th task 
      Console.WriteLine("Checking Change event:");
      num1.Change += FractionChange;
      num1.Nominator = 2;
      num1.Denominator = 5;

      Console.WriteLine("");

      // checking getting a decimal from a fraction 
      Console.WriteLine($"A decimal from the first fraction: {Utils.GetDecimal(num1)}");

      Console.WriteLine("");

      // checking addition
      MyFraction result1 = num1 + num2;
      Console.WriteLine("Addition:");
      Console.WriteLine(result1.Nominator);
      Console.WriteLine("---");
      Console.WriteLine(result1.Denominator);

      Console.WriteLine("");

      // checking substration
      MyFraction result2 = num1 - num2;
      Console.WriteLine("Substraction:");
      Console.WriteLine(result2.Nominator);
      Console.WriteLine("---");
      Console.WriteLine(result2.Denominator);

      Console.WriteLine("");

      // checking multiplication and fraction shortening
      MyFraction result3 = num1 * num2;
      Console.WriteLine("Multiplication:");
      Console.WriteLine(result3.Nominator);
      Console.WriteLine("---");
      Console.WriteLine(result3.Denominator);

      Console.WriteLine("");

      // checking division and fraction shortening
      MyFraction result4 = num1 / num2;
      Console.WriteLine("Division:");
      Console.WriteLine(result4.Nominator);
      Console.WriteLine("---");
      Console.WriteLine(result4.Denominator);

      Console.WriteLine("");

      // indexer check 
      MyFraction num3 = new MyFraction(10, 35);
      Console.WriteLine("Indexer checking:");
      Console.WriteLine($"index 0 for num1: {num3[0]}");
      Console.WriteLine($"index 1 for num1: {num3[1]}");
    }

    // method for the delegate and event from the 4th task 
    public static void FractionChange(MyFraction fraction, int num) {
      Console.WriteLine("Change event fired");
    }
  }
}