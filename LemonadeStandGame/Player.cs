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
    public Player()
    {
      inventory = new Inventory();
      cash = 20.00;
    }
  }
}
