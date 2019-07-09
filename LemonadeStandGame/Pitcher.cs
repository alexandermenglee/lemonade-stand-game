using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Pitcher
  {
    public int cupsInPitcher;
    Recipe recipe;
    public Pitcher(Recipe recipe)
    {
      this.recipe = recipe;
      cupsInPitcher = 6;
    }

    public void RemoveIngredientsFromInventory()
    {

    }
  }
}
