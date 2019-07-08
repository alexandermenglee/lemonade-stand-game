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

    public Game()
    {
      days = new List<Day>();
      ui = new UserInterface();
      randomNumber = new Random();
      player = new Player();
      store = new Store();
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
      int indexOfDay;
      indexOfDay = 0;

      while(indexOfDay < days.Count)
      {
        ui.ShowCurrentDay(indexOfDay, days.Count);
        ui.DisplayWeather(days[indexOfDay].weather);
        store.ShowStore(player);
        ui.RecipeWelcomePage();
        // asks for recipe for the current day and save the number to a variable
        days[indexOfDay].recipe.SetQuantityOfIngredients(days[indexOfDay]);
        days[indexOfDay].SellLemonadeSimulation(player, days[indexOfDay].recipe);
        indexOfDay++;
      }
    }



  }
}