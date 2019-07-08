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
    public List<Customer> customers;
    public UserInterface ui;

    public Day(Random randomNumber)
    {
      this.randomNumber = randomNumber;
      weather = new Weather(randomNumber);
      recipe = new Recipe();
      customers = new List<Customer>();
      ui = new UserInterface();
    }

    public void SellLemonadeSimulation(Player player, Recipe recipe)
    {
      int pitcher;
      int lemonQuantity;
      int cupsQuantity;
      int sugarQuantity;
      int iceQuantity;

      lemonQuantity = player.inventory.lemons.Count;
      cupsQuantity = player.inventory.cups.Count;
      sugarQuantity = player.inventory.cupsOfSugar.Count;
      iceQuantity = player.inventory.iceCubes.Count;
      pitcher = 6;

      GenerateCustomers();

      for(int i = 0; i < customers.Count; i++)
      {
        customers[i].SetWillBuy(recipe);
      }
      
      for(int i = 0; i < customers.Count; i++)
      {
        /*Console.WriteLine($"\nWill Buy: {customers[i].willBuy}\n" +
          $"Thirst: {customers[i].thirsty}\n" +
          $"Acceptable Price: {customers[i].acceptablePrice}\n");*/

        if (customers[i].willBuy == true)
        {
          // check for enough cups, ice, sugar and lemons
          if (cupsQuantity >= 1 && lemonQuantity >= recipe.lemonsPerPitch && sugarQuantity >= recipe.sugarPerPitcher && iceQuantity >= recipe.icePerCup)
          {
            // remove ingredients from inventory
            player.inventory.cups.RemoveRange(0, 1);
            player.inventory.iceCubes.RemoveRange(0, recipe.icePerCup);

            if (pitcher == 6)
            {
              player.inventory.lemons.RemoveRange(0, recipe.lemonsPerPitch);
              player.inventory.cupsOfSugar.RemoveRange(0, recipe.sugarPerPitcher);
              pitcher = 0;
            }

            player.cash += recipe.pricePerCup;
            player.profit += recipe.pricePerCup;
            pitcher++;
          }
          else
          {
            ui.ShowSoldOutMessage();
            break;
          }
        }
      }
    }

    public void GenerateCustomers()
    {
      for (int i = 0; i < 5; i++)
      {
        Customer customer = new Customer(weather, randomNumber);
        customers.Add(customer);
      }
    }

  }
}