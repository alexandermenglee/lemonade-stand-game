using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Recipe
  {
    public int lemonsPerPitch;
    public int icePerCup;
    public int sugarPerPitcher;
    public double pricePerCup;
    public UserInterface ui = new UserInterface();
    public Recipe()
    {
    }
    public void SetQuantityOfIngredients(Day day)
    {
      lemonsPerPitch =  ui.LemonsPerPitcher();
      icePerCup = ui.IcePerCup();
      sugarPerPitcher = ui.SugarPerPitcher();
      pricePerCup = ui.PricePerCup();
    }

  }
}
