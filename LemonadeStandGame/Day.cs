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

    public Day(Random randomNumber)
    {
      this.randomNumber = randomNumber;
      weather = new Weather(randomNumber);
      recipe = new Recipe();
      customers = new List<Customer>();
    }

    public void SellLemonadeSimulation(Recipe recipe)
    {
      GenerateCustomers();
     
      for(int i = 0; i < customers.Count; i++)
      {
        customers[i].SetWillBuy(recipe);
        Console.WriteLine($"Acceptable Price: {customers[i].acceptablePrice} " +
          $"\nThirsty: {customers[i].thirsty} " +
          $"\nWill Buy: {customers[i].willBuy}\n");
      }
    }

    public void GenerateCustomers()
    {
      for (int i = 0; i < 10; i++)
      {
        Customer customer = new Customer(weather, randomNumber);
        customers.Add(customer);
      }
    }

  }
}