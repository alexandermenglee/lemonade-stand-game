using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Game
  {
    public List<Day> days;
    Random randomNumber;
    public UserInterface ui;
    public Player player;
    public Store store;
    public Recipe recipe;
    public Game()
    {
      days = new List<Day>();
      ui = new UserInterface();
      randomNumber = new Random();
      player = new Player();
      store = new Store();
      recipe = new Recipe();
    }

    public void Initialize()
    {
      ui.DisplayRules();
      int amountOfDays;

      amountOfDays = int.Parse(ui.AskDuration());

      // Creates day objects depending on user input and pushes them into a List
      for (int i = 0; i < amountOfDays; i++)
      {
        days.Add(new Day(randomNumber));
      }
    }

    public void StartGame()
    {
      ui.DisplayWeather(days[0].weather);
      store.ShowStore(player);
    }



  }
}