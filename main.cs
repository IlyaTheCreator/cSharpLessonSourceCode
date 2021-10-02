using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Machines;

class MyClass 
{
  public static void Main(string[] args) 
  {
    // creating a new coffee machine for no reason
    CoffeeMachine coffeeMachine = new CoffeeMachine(new List<string>() {
      "Coffee",
      "Coffee with sugar",
      "Coffee with cream",
      "Hot chocolate",
      "Water",
    });

    Console.WriteLine("Биба");
  }
}
