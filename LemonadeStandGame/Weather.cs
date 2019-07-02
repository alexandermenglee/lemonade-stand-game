using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Weather
  {
    private string[] forecastArray;
    public int temperature;
    public string forecast;
    Random randomNumber;

    public Weather(Random randomNumber)
    {
      this.randomNumber = randomNumber;
      forecastArray = new string[] { "sunny", "cloudy", "rainy", "hazy" };
      SetForecast();
      SetTemperature();
    }

    public void SetForecast()
    {
      // Generate a random forecast
      int forecastIndex = randomNumber.Next(0, forecastArray.Length);
      forecast = forecastArray[forecastIndex];
    }

    public void SetTemperature()
    {
      // Generate random temperatue between 48 and 103 degrees
      temperature = randomNumber.Next(48, 103);
    }

  }
}
