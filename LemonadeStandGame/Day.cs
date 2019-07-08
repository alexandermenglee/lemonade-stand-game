using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Day
  {
    public Weather weather;
    public Random randomNumber;
    public Recipe recipe;
    public int lemonsPerPitch;
    public int icePerCup;
    public int sugarPerPitcher;
    public double pricePerCup;

    public Day(Random randomNumber)
    {
      this.randomNumber = randomNumber;
      weather = new Weather(randomNumber);
      recipe = new Recipe();
    }

  }
}