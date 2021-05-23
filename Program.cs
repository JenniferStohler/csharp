using System;
using System.Collections.Generic;
using System.Threading;
using csharp.Models;



namespace csharp
{
  class Program
  {
    private const int V = 1;
    public bool selecting = true;
    static void Main(string[] args)
    {

      //Clears the terminal

      Console.Clear();

      //Asks the question
      //   while (selecting)
      //   {

      //   }
      Console.WriteLine("Wanna play Rock, Paper, Scissors? (Y/N)");

      //Type an answer to the question
      Game rps = new Game();

      string userInput = Console.ReadLine();
      if (userInput == "Y")
      {
        Console.WriteLine("Let the game begin!");
        Console.Write("Choose Rock, Paper, or Scissors:");
      }
      if (userInput == "N")
      {
        Console.WriteLine("You have no choice but to play!");
        Console.Write("Choose Rock, Paper, or Scissors:");

      }

      bool playing = true;
      while (playing)
      {
        string computerInput = Console.ReadLine();
        if (computerInput = 1)
        {
          if (userInput == "Rock")
          {
            Console.WriteLine("Computer uses Rock!");
            Console.WriteLine("It is a tie!");
          }
          else if (userInput == "Paper")
          {
            Console.WriteLine("Computer used Paper!");
            Console.WriteLine("It is a tie!");
          }
          else if (userInput == "Scissors")
          {
            Console.WriteLine("Computer used Scissors!");
            Console.WriteLine("It is a tie!");

          }
        }

        if (computerInput = 2)
        {
          if (userInput == "Rock")
          {
            Console.WriteLine("Computer used Paper!");
            Console.WriteLine("You lose!");
          }
          else if (userInput == "Paper")
          {
            Console.WriteLine("Computer used Scissors!");
            Console.Write("You lose!");
          }
          else if (userInput == "Scissors")
          {
            Console.WriteLine("Computer used Rock!");
            Console.WriteLine("You lose!");
          }
        }
        if (computerInput = 3)
        {
          if (userInput == "Rock")
          {
            Console.WriteLine("Computer used Scissors!");
            Console.WriteLine("You win!");
          }
          else if (userInput == "Paper")
          {
            Console.WriteLine("Computer used Rock!");
            Console.WriteLine("You win!");
          }
          else if (userInput == "Scissors")
          {
            Console.WriteLine("Computer used Paper!");
            Console.WriteLine("You win!");
          }
        }

      }
      //Choose Rock, Paper, or Scissors




      //Displays only the question in the terminal
      string name = Console.ReadLine();


    }
  }
}
