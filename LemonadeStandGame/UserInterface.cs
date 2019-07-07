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

    public void DisplayWeather(Weather weather)
    {
      Console.WriteLine($"\n********** WEATHER **********\nToday's weather is: {weather.forecast} with a high of {weather.temperature} degrees\n");
    }

    // Asking how many days the user would like to play for
    public string AskDuration()
    {
      string duration;
      Console.WriteLine("How many days would you like to play for? (enter '7', '14', or '30')");
      duration = Console.ReadLine();
      duration.Trim();

      if(duration == "7" || duration == "14" || duration == "30")
      {
        return duration;
      }

      Console.WriteLine("\nPlease enter '7', '14' or '30'\n");

      return AskDuration();
    }

    public int AskForCups()
    {
      int quatity;
      string userInput;
      
      Console.WriteLine("How many cups would you like purchase? (25 cups for $.79, 50 cups for $.1.57, 100 cups for $3.13)");
      userInput = Console.ReadLine().ToLower().Trim();

      if(userInput == "25" || userInput == "50" || userInput == "100")
      {
        quatity = int.Parse(userInput);
        return quatity;
      }
      else
      {
        Console.WriteLine("Please enter in an amount (25, 50, or 100)\n");
        return AskForCups();
      }
    }

    public int AskForLemons()
    {
      int quatity;
      string userInput;

      Console.WriteLine("How many lemons would you like to purchase? (10 lemons for $.56, 30 lemons for $2.12, 75 lemons for $4.14)");
      userInput = Console.ReadLine().ToLower().Trim();

      if (userInput == "10" || userInput == "30" || userInput == "75")
      {
        quatity = int.Parse(userInput);
        return quatity;
      }
      else
      {
        Console.WriteLine("Please enter in an amount (10, 30 or 75)\n");
        return AskForLemons();
      }
    }

    public int AskForSugar()
    {
      int quatity;
      string userInput;

      Console.WriteLine("How much sugar would you like to purchase? (8 cups of sugar for $.66, 20 cups of sugar for $1.71, 48 cups of sugar for 3.37)"); 
      userInput = Console.ReadLine().ToLower().Trim();

      if (userInput == "8" || userInput == "20" || userInput == "48")
      {
        quatity = int.Parse(userInput);
        return quatity;
      }
      else
      {
        Console.WriteLine("Please enter in an amount (8, 20 or 48)\n");
        return AskForSugar();
      }
    }
    public int AskForIce()
    {
      int quatity;
      string userInput;

      Console.WriteLine("How much ice would you like to purchase? (100 ice cubes for $.75, 250 ice cubes for $2.12, 500 ice cubes for $3.88)");
      userInput = Console.ReadLine().ToLower().Trim();

      if (userInput == "100" || userInput == "250" || userInput == "500")
      {
        quatity = int.Parse(userInput);
        return quatity;
      }
      else
      {
        Console.WriteLine("Please enter in an amount (100, 250 or 500)\n");
        return AskForIce();
      }
    }

    public void DisplayWelcomeMessage()
    {
      Console.WriteLine("Welcome To The Lemonade Stand Store!");
    }

    public string DisplayStore()
    {
      string userInput;

      Console.WriteLine("\nType in what you'd like to purchase. \n- cups\n- lemons\n- sugar\n- ice\n- finished(If you wish to not purchase any ingredients or you are complete with purchasing)");
      userInput = Console.ReadLine();
      userInput.ToLower().Trim();

      if(userInput == "cups" || userInput == "lemons" || userInput == "sugar" || userInput == "ice")
      {
        return userInput;
      }
      else if(userInput == "finished")
      {
        return "";
      }
      else
      {
        Console.WriteLine("Please enter in one of the folllowing: cups, lemons, sugar, ice or finished\n");
        return DisplayStore();
      }
    }

    public void DisplayPlayerInventory(Inventory inventory, Player player)
    {
      Console.WriteLine(
        "********************************************************************" + 
        $"\nYou have: {player.cash.ToString("0.00")}\n" +
        $"\nYour Inventory:" +
        $"\nCups: {inventory.cups.Count} cups\n" +
        $"Lemons: {inventory.lemons.Count} lemons\n" +
        $"Sugar: {inventory.cupsOfSugar.Count} cups of sugar\n" +
        $"Ice: {inventory.iceCubes.Count} ice cubes\n"
        );
    }

    public void BackToStoreMenu()
    {
      Console.WriteLine("Press 'Enter' to return to the store menu");
      Console.ReadLine();
    }

    public void RecipeWelcomePage()
    {
      Console.WriteLine("\n******************************************************************** \nWelcome To The Recipe Maker!\n");
    }

    public void AskForRecipe()
    {
      string lemonsPerPitcher;
      string icePerCup;
      string sugarPerPitcher;
      double pricePerCup;

      Console.WriteLine("How many lemons per pitcher do you wish to add?");
      lemonsPerPitcher = Console.ReadLine();

      Console.WriteLine("How many ice cubes per cup would you like to add?");
      icePerCup = Console.ReadLine();

      Console.WriteLine("How much sugar would you like to put per pitcher?");
      sugarPerPitcher = Console.ReadLine();

      Console.WriteLine("Enter in the amount each cup of lemonade costs: ");
      pricePerCup = double.Parse(Console.ReadLine());
    }
    
  }
}
