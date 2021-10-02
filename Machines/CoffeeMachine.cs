using System;
using System.Collections.Generic;
using MachineBehaviors;
using MachineProvisions;

namespace Machines
{
  class CoffeeMachine : 
    ChooseDrink,
    ChooseDrinkIngredients,
    CookDrink,
    GiveChange,
    GiveDrink,
    TakeCash
  {
    public List<string> DrinkTypes { get; set; }

    public CoffeeMachine(List<string> drinkTypes)
    {
      DrinkTypes = drinkTypes;
    }

    public void ExecuteTask(string task)
    {
      Console.WriteLine($"Executing: {task}");
    }

    public void ChooseDrink(Drink drink)
    {
      ExecuteTask("choosing a drink...");
    } 

    public void ChooseIngredients(List<string> ingredients)
    {
      ExecuteTask("choosing drink ingredients...");
    }

    public void CookDrink(Drink drink) 
    {
      ExecuteTask("cooking a drink...");
    }
    
    public void GiveChange(double amount)
    {
      ExecuteTask("giving change...");
    }

    public void GiveDrink(Drink drink)
    {
      ExecuteTask("giving drink...");
    }

    public void TakeCash(double amount) 
    {
      ExecuteTask("taking cash...");
    }
  }
}