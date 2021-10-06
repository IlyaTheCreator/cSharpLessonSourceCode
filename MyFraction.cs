using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RPM
{
  public class MyFraction
  {
    // constructors
    public MyFraction(int nominator, int denominator)
    {
      if (denominator == 0)
      {
        throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
      }

      // setting the right sign
      
      if (Math.Sign(nominator / denominator) == 1)
      {
        Sign = '+';
      }

      if (Math.Sign(nominator / denominator) == -1)
      {
        Sign = '-';
      }

      Nominator = nominator;
      Denominator = denominator;
    }

    public MyFraction() {}

    // fields 
    private int _nominator;
    private int _denominator;

    // properties
    public char Sign { get; set; }

    // delegate for the 4th task 
    // fraction - just an instance 
    // num - nomenator or denominator 
    public delegate void FractionChangeDelegate(MyFraction fraction, int num);

    // event for the 4th task 
    public event FractionChangeDelegate Change;

    // each time we update nominator or denominator, we have to make new checks for 
    // the fraction's sign
    public int Nominator 
    {
      get {
        return _nominator;
      }

      set {
        // 4th task - call the event 
        if (Change != null)
        {
          Change(this, value);
        }

        Sign = Utils.CalcSign(Denominator, value);
        _nominator = value;
      }
    }

    public int Denominator 
    {
      get {
        return _denominator;
      }

      set {
        // 4th task - call the event 
        if (Change != null)
          Change(this, value);

        Sign = Utils.CalcSign(Nominator, value);
        _denominator = value;
      }
    }

    // indexer - 5th task 
    public int this[int index]
    {
      get {
        if (index == 0)
        {
          return Nominator;
        }

        if (index == 1)
        {
          return Denominator;
        }

        return -1;
      }
    }

    // addition
    public static MyFraction operator +(MyFraction num1, MyFraction num2) 
    {
      return Utils.MathOperationHandler(num1, num2, MathAction.ADD);
    }

    // substration
    public static MyFraction operator -(MyFraction num1, MyFraction num2)
    {
      return Utils.MathOperationHandler(num1, num2, MathAction.SUBSTRACT);
    }

    // multiplication 
    public static MyFraction operator *(MyFraction num1, MyFraction num2)
    {
      return Utils.MathOperationHandler(num1, num2, MathAction.MULTIPLY);
    }

    // division
    public static MyFraction operator /(MyFraction num1, MyFraction num2)
    {
      return Utils.MathOperationHandler(num1, num2, MathAction.DIVIDE);
    }
  }
}