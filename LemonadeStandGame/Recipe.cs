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
      lemon = new Lemon();
    }
  }
}
