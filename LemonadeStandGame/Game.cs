using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Game
  {
    public List<Day> days = new List<Day>();
    UserInterface ui;
    Random randomNumber;
    public Game()
    {
      ui = new UserInterface();
      randomNumber = new Random();
    }

    public void Initialize()
    {
      ui.DisplayRules();
      int amountOfDays;

      amountOfDays = int.Parse(ui.AskDuration());

      for (int i = 0; i < amountOfDays; i++)
      {
        days.Add(new Day(randomNumber));
      }

      // testing only
      for(int i = 0; i < days.Count; i++)
      {
        Console.WriteLine($"Day {i}: \nForecast:{days[i].weather.forecast} \nTemperature: {days[i].weather.temperature}");
      }

      Console.ReadLine();
    }

    

  }
}