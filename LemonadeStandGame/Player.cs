using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Player
  {
    public double cash;
    public Inventory inventory;
    public Recipe recipe;
    public UserInterface ui = new UserInterface();
    public Player()
    {
      inventory = new Inventory();
      recipe = new Recipe();
      cash = 20.00;
    }

    public void SetRecipe()
    {
      ui.RecipeWelcomePage();
      ui.AskForRecipe();
    }
  }
}
