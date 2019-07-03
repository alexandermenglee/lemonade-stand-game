using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  public abstract class Ingredient
  {
    public int quantity;
    public Ingredient()
    {
      this.quantity = 0;
    }

  }
}
