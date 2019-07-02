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

    public Weather()
    {
      // Generate a random forecast
      forecastArray = new string[] { "sunny", "cloudy", "rainy", "hazy" };
      Random randomForecast = new Random();
      int forecastIndex = randomForecast.Next(0, forecastArray.Length);
      forecast = forecastArray[forecastIndex];

      // Generate random temperatue between 48 and 103 degrees
      Random randomTemperatue = new Random();
      temperature = randomTemperatue.Next(48, 103);
    }
  }
}
