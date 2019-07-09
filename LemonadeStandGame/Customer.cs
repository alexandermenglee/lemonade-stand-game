using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Customer
  {
    public bool thirsty;
    public double acceptablePrice;
    public Random random;
    public bool willBuy;
    public Customer(Weather weather, Random random)
    {
      this.random = random;
      SetAcceptablePrice(weather);
      CheckThirst(weather);
    }

    public void SetAcceptablePrice(Weather weather)
    {
      if (weather.temperature < 54)
      {
        // generate a number from .01 to .30
        CheckForecast(weather, .01, .30);
      }
      else if (weather.temperature >= 54 && weather.temperature <= 70)
      {
        // generate a number from .30 - 1.00
        CheckForecast(weather, .31, 1.00);
      }
      else if(weather.temperature > 70)
      {
        // generate a number from 1.50 and 2.25
        CheckForecast(weather, 1.50, 2.25);
      }
    }

    public void CheckForecast(Weather weather, double minimumAcceptablePrice, double maxAcceptablePrice)
    {
      switch (weather.forecast)
      {
        case "sunny":
          acceptablePrice = random.NextDouble(minimumAcceptablePrice, maxAcceptablePrice + .1);
          break;
        case "cloudy":
          acceptablePrice = random.NextDouble(minimumAcceptablePrice, maxAcceptablePrice - .04);
          break;
        case "rainy":
          acceptablePrice = random.NextDouble(minimumAcceptablePrice, maxAcceptablePrice - .1);
          break;
        case "hazy":
          acceptablePrice = random.NextDouble(minimumAcceptablePrice, maxAcceptablePrice - .08);
          break;
      }
    }

    public void CheckThirst(Weather weather)
    {
      if(weather.temperature > 85)
      {
        if (random.Next(88, 101) > 90)
        {
          thirsty = true;
        }
        else
        {
          thirsty = false;
        }
      }
      else if(weather.temperature >= 54 && weather.temperature <= 84)
      {
        if(random.Next(75, 101) > 90)
        {
          thirsty = true;
        }
        else
        {
          thirsty = false;
        }
      }
      else
      {
        if(random.Next(50, 101) > 90)
        {
          thirsty = true;
        } 
        else
        {
          thirsty = false;
        }
      }
    }

    // method determines weather a customer will buy or not
    public void SetWillBuy(Recipe recipe)
    {
      if(recipe.pricePerCup < acceptablePrice && thirsty == false)
      {
        if(random.Next(20, 101) > 75)
        {
          willBuy = true;
        }
        else
        {
          willBuy = false;
        }
      }
      else if(thirsty == true && recipe.pricePerCup > acceptablePrice)
      {
        if(random.Next(40, 101) > 75)
        {
          willBuy = true;
        }
        else
        {
          willBuy = false;
        }
      }
      else if(thirsty == true && recipe.pricePerCup < acceptablePrice)
      {
        willBuy = true;
      }
      else if(thirsty == false && recipe.pricePerCup > acceptablePrice)
      {
        willBuy = false;
      }
    }
  }
}