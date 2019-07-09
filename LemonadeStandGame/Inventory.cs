using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Inventory
  {
    public List<Cup> cups;
    public List<Lemon> lemons;
    public List<Sugar> cupsOfSugar;
    public List<Ice> iceCubes;

    public Inventory()
    {
      cups = new List<Cup>();
      lemons = new List<Lemon>();
      cupsOfSugar = new List<Sugar>();
      iceCubes = new List<Ice>();
    }

    // helper methods to check inventory
    public bool CheckCups(List<Cup> cup)
    {
      if(cups.Count >= 1)
      {
        return true;
      }

      return false;
    }

    public bool CheckLemons(List<Lemon> lemons, Recipe recipe)
    {
      if (lemons.Count >= recipe.lemonsPerPitch)
      {
        return true;
      }

      return false;
    }

    public bool CheckSugar(List<Sugar> sugar, Recipe recipe)
    {
      if(sugar.Count >= recipe.sugarPerPitcher)
      {
        return true;
      }

      return false;
    }

    public bool CheckIce(List<Ice> ice, Recipe recipe)
    {
      if(ice.Count >= recipe.icePerCup)
      {
        return true;
      }

      return false;
    }
  }
}
