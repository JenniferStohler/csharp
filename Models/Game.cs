using System;
using System.Collections.Generic;

namespace csharp.Models

{
  public class Game
  {
    List<string> computerChoice = new List<string>()
    {
"Rock", "Paper", "Scissors"
    };
    public Game()
    {
      //Random number method here
      Random rps = new Random();
      int computerChoice = rps.Next(1, 3);

    }

    String[] plays = new string[] { "Rock", "Paper", "Scissors" };


  }
}

