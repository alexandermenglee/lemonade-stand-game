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

    

  }
}
