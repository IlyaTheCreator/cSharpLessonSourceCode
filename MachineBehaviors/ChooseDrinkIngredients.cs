using System.Collections.Generic;
using MachineProvisions;

namespace MachineBehaviors
{
  interface ChooseDrinkIngredients : Behavior
  {
    void ChooseIngredients(List<string> ingredients);
  }
}