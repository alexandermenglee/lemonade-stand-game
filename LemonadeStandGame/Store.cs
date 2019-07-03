using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Store
  {
    public UserInterface ui;

    public Store()
    {
      ui = new UserInterface();
    }

    public void ShowStore(Player player)
    {
      ui.DisplayPlayerInventory(player.inventory, player);
    }

    public double GetCups()
    {
      return double.Parse(ui.AskForCups());
    }

    public double GetLemons()
    {
      return double.Parse(ui.AskForLemons());
    }

    public double GetSugar()
    {
      return double.Parse(ui.AskForSugar());
    }

    public double GetIce()
    {
      return double.Parse(ui.AskForIce());
    }

  }
}
