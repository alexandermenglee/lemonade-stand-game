using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class UserInterface
  {
    public UserInterface()
    {

    }

    public void DisplayRules()
    {
      Console.WriteLine("Rules are ... Press 'enter' to continue");
      Console.ReadLine();
    }

    public string AskDuration()
    {
      Console.WriteLine("How many days would you like to play for? (enter '7', '14', or '30')");
      return Console.ReadLine();
    }

    public string AskForCups()
    {
      Console.WriteLine("How many cups would you like purchase? (25 cups for $.79, 50 cups for $.1.57, 100 cups for $3.13)");
      return Console.ReadLine();
    }

    public string AskForLemons()
    {
      Console.WriteLine("How many lemons would you like to purchase? (10 lemons for $.56, 30 lemons for $2.12, 75 lemons for $4.14)");
      return Console.ReadLine();
    }

    public string AskForSugar()
    {
      Console.WriteLine("How much sugar would you like to purchase? (8 cups of sugar for $.66, 20 cups of sugar for $1.71, 48 cups of sugar for 3.37)");
      return Console.ReadLine();
    }
    public string AskForIce()
    {
      Console.WriteLine("How much ice would you like to purchase? (100 ice cubes for $.75, 250 ice cubes for $2.12, 500 ice cubes for $3.88)");
      return Console.ReadLine();
    }

    
  }
}
