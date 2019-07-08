using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Recipe
  {
    public Lemon lemon;
    public Cup cup;
    public Sugar sugar;
    public Ice iceCubes;
    public UserInterface ui = new UserInterface();
    public Recipe()
    {
    }

    public int GetLemons()
    {
      return ui.LemonsPerPitcher();
    }

    public int GetIcePerCup()
    {
      return ui.IcePerCup();
    }

    public int GetSugarPerPitch()
    {
      return ui.SugarPerPitcher();
    }

    public double GetPricePerCup()
    {
      return ui.PricePerCup();
    }

    public void SetQuantityOfIngredients(Day day)
    {
      day.lemonsPerPitch =  ui.LemonsPerPitcher();
      day.icePerCup = ui.IcePerCup();
      day.sugarPerPitcher = ui.SugarPerPitcher();
      day.pricePerCup = ui.PricePerCup();
    }

  }
}
