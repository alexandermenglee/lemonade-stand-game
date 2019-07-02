using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Game
  {
    public int days;
    public List<Weather> weatherCollection = new List<Weather>();
    Random rng;
    public Game()
    {
      rng = new Random();
    }

    public void Initialize()
    {
      DisplayRules();
      GetDays();

      for(int i = 0; i < days; i++)
      {
        CreateWeather(i+1, rng);
      }

      // Used for testing only
      for (int i = 0; i < weatherCollection.Count; i++)
      {
        Console.WriteLine($"Weather ID: {weatherCollection[i].weatherId}: Forecast: {weatherCollection[i].forecast} Temperature: {weatherCollection[i].temperature}");
      }

      Console.ReadLine();
    }

    public void DisplayRules()
    {
      Console.WriteLine("Rules are ... Press 'enter' to continue");
      Console.ReadLine();
    }

    public int GetDays()
    {
      Console.WriteLine("How many days would you like to play for? (7, 14, 30)");

      return days = Convert.ToInt32(Console.ReadLine());
    }

    public void CreateWeather(int id, Random rng)
    {
      Weather weather = new Weather(id, rng);
      weather.SetForecast();
      weather.SetTemperature();
      weatherCollection.Add(weather);
    }

  }
}