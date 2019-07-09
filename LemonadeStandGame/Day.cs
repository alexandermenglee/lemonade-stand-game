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
      int sold;
      int pitcher;
      int pitcherEmpty;

      sold = 0;
      pitcher = 0;
      pitcherEmpty = 0;

      GenerateCustomers();

      // call SetWillBuy on each customer
      for(int i = 0; i < customers.Count; i++)
      {
        customers[i].SetWillBuy(recipe);
      }
      
      // check each customer's willBuy variable
      for(int i = 0; i < customers.Count; i++)
      {
        // pitcher starts out empty (equal to 0)

        if (customers[i].willBuy == true)
        {
          // if pitcher is equal to 0 check:
          if (pitcher == pitcherEmpty)
          {
            // check if there are enough lemons
            // check if there is enough sugar
            // check if there are enough cups
            // check if there is enough ice
            if (player.inventory.CheckLemons(player.inventory.lemons, recipe) &&
               player.inventory.CheckSugar(player.inventory.cupsOfSugar, recipe) &&
               player.inventory.CheckCups(player.inventory.cups) &&
               player.inventory.CheckIce(player.inventory.iceCubes, recipe)
              )
            {
              // if all are true, create a pitcher (set it equal to 6) 
              // remove ingredients from inventory
              // decrement pitcher by 1
              pitcher = 6;
              player.inventory.cups.RemoveRange(0, 1);
              player.inventory.lemons.RemoveRange(0, recipe.lemonsPerPitch);
              player.inventory.cupsOfSugar.RemoveRange(0, recipe.sugarPerPitcher);
              player.inventory.iceCubes.RemoveRange(0, recipe.icePerCup);

              player.cash += recipe.pricePerCup;
              player.profit += recipe.pricePerCup;
              sold++;
              pitcher--;
              continue;
            }
            else
            {
              ui.ShowSoldOutMessage();
              break;
            }
          }

          // if pitcher is not equal to zero
          // check cups
          // check ice
          if(player.inventory.CheckCups(player.inventory.cups) && player.inventory.CheckIce(player.inventory.iceCubes, recipe))
          {
            // if both are true, remove both from inventory
            player.inventory.cups.RemoveRange(0, 1);
            player.inventory.iceCubes.RemoveRange(0, recipe.icePerCup);

            player.cash += recipe.pricePerCup;
            player.profit += recipe.pricePerCup;
            sold++;
            pitcher--;
          }
          else
          {
            ui.ShowSoldOutMessage();
            break;
          }
        }
      }
      ui.DisplaySoldCups(sold);
    }

    public void GenerateCustomers()
    {
      for (int i = 0; i < 100; i++)
      {
        Customer customer = new Customer(weather, randomNumber);
        customers.Add(customer);
      }
    }
  }

  
}