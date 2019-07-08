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
    public double profit;
    public double loss;
    public Inventory inventory;
    public UserInterface ui = new UserInterface();
    public Player()
    {
      inventory = new Inventory();
      cash = 20.00;
      profit = 0.0;
      loss = 0.0;
    }
  }
}
