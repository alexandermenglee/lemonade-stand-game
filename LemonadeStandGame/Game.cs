using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Game
  {
    public Game()
    {

    }

    public void Initialize()
    {
      Console.WriteLine("Game has initialized...");
    } 

    public void DisplayRules()
    {
      Console.WriteLine("Rules are...");
    }

    public int GetDays()
    {
      string answer;

      Console.WriteLine("How many days would you like to play for? (7, 14, 30)");
      answer = Console.ReadLine();

      return Convert.ToInt32(answer);
    }

  }
}
