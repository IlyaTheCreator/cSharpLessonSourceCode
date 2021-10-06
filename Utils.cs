using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RPM
{
  // the purpose of this class is to reduce complexity of MyFraction class
  public class Utils
  {
    // Euclidean algorithm implementation. Hello to all ancient Greek mathmatitians
    public static int FindGreatestCommonDivisor(int num1, int num2)
    {
      while (num1 != 0 && num2 != 0)
      {
        if (num1 > num2)
          num1 %= num2;
        else
          num2 %= num1;
      }

      return num1 | num2;
    }

    public static MyFraction ShortenFraction(MyFraction num)
    {
      // greatest common divisor 
      int gcd = Utils.FindGreatestCommonDivisor(num.Nominator, num.Denominator);

      num.Nominator /= gcd;
      num.Denominator /= gcd;

      return num;
    }

    public static MyFraction AddSubstractHandler(MyFraction num1, MyFraction num2, MathAction action)
    { 
      // preparing output variable
      MyFraction resultFraction = new MyFraction();

      // creating variables which we can change later in the if statement
      int newNominator1, newNominator2, newNominator, newDenominator;

      // based on equality or unequality of denominators, their further calculations are different
      if (num1.Denominator != num2.Denominator)
      {
        newNominator1 = num1.Nominator * num2.Denominator;
        newNominator2 = num2.Nominator * num1.Denominator;
        // the only difference between addition and substration is handled here by a ternary operator
        newNominator = action == MathAction.ADD ? newNominator1 + newNominator2 : newNominator1 - newNominator2;
        newDenominator = num1.Denominator * num2.Denominator;
        resultFraction.Nominator = newNominator;
        resultFraction.Denominator = newDenominator;
      } else 
      {
        // ternary operator again
        newNominator = action == MathAction.ADD ? num1.Nominator + num2.Nominator : num1.Nominator - num2.Nominator;
        resultFraction.Nominator = newNominator;
        resultFraction.Denominator = num1.Denominator;
      }

      return resultFraction;
    }

    public static MyFraction MultiplyDivideHandler(MyFraction num1, MyFraction num2, MathAction action)
    {
      // preparing output variable
      MyFraction resultFraction = new MyFraction();

      // in case of division we simply reverse the second fraction
      if (action == MathAction.DIVIDE)
      {
        int nominator = num2.Nominator;
        int denominator = num2.Denominator;
        num2.Denominator = nominator;
        num2.Nominator = denominator;
      }

      resultFraction.Nominator = num1.Nominator * num2.Nominator;
      resultFraction.Denominator = num1.Denominator * num2.Denominator;

      // attempting to shorten the result fraction 
      resultFraction = Utils.ShortenFraction(resultFraction);

      return resultFraction;
    }

    public static MyFraction MathOperationHandler(MyFraction num1, MyFraction num2, MathAction action)
    {
      MyFraction output = new MyFraction();

      switch (action)
      {
        case MathAction.ADD:
        case MathAction.SUBSTRACT:
          output = Utils.AddSubstractHandler(num1, num2, action);
          break;
        case MathAction.MULTIPLY:
        case MathAction.DIVIDE:
          output = Utils.MultiplyDivideHandler(num1, num2, action);
          break;
        default:
          break;
      }

      return output;
    }

    public static decimal GetDecimal(MyFraction num)
    {
      // nominator and denominator are of int type, that's why we have type convertion here 
      return Math.Round((decimal) num.Nominator / (decimal) num.Denominator, 4);
    }

    // each time we update nominator or denominator, we have to make new checks for 
    // the fraction's sign
    public static char CalcSign(int num1, int num2)
    {
      char output = ' ';

      if (Math.Sign(num1 / num2) == 1)
      {
        output =  '+';
      }

      if (Math.Sign(num1 / num2) == -1)
      {
        output =  '-';
      }

      return output;
    }
  }
}