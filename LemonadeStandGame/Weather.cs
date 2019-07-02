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
    public int weatherId;
    Random rng;

    public Weather(int weatherId, Random rng)
    {
      this.rng = rng;
      this.weatherId = weatherId;
      forecastArray = new string[] { "sunny", "cloudy", "rainy", "hazy" };
    }

    public void SetForecast()
    {
      // Generate a random forecast
      
      int forecastIndex = rng.Next(0, forecastArray.Length);
      forecast = forecastArray[forecastIndex];
    }

    public void SetTemperature()
    {
      // Generate random temperatue between 48 and 103 degrees
      temperature = rng.Next(48, 103);
    }

  }
}
