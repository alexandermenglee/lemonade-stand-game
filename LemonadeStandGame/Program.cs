﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Game game = new Game();
      game.Initialize();
      game.StartGame();

      Console.ReadLine();
    }
  }
}
