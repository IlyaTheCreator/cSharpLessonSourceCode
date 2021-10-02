using System.Collections.Generic;

namespace MachineProvisions 
{
  class DrinkWithIngredients : Drink 
  {
    public List<string> Ingredients { get; set; }

    public DrinkWithIngredients(string drinkType, List<string> ingredients) : base(drinkType)
    {
      Ingredients = ingredients;
    }
  }
}