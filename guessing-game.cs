using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
      static void Main(string[] args)
      {
        // Initiate variables
        string secretWord = "giraffe";
        string guess = "";
        // Want to limit the number of guesses a user can make
        // Create integer to keep track of how many times the user has guessed
        int guessCount = 0;
        // Create integer to limit the number of guesses a user can make
        int guessLimit = 3;
        // Indicates whether or not the user is out of guesses
        bool outOfGuesses = false;

        while(guess != secretWord && !outOfGuesses)
        {
          if(guessCount < guessLimit)
          {
            // Prompt the user to guess the word
            // Writes the value to the screen without adding a new line character
            Console.Write("Enter guess: ");
            // Store the user's response inside the guess variable
            guess = Console.ReadLine();
            // Want to increment each time the user guesses
            guessCount++;
          }
          else
          {
            outOfGuesses = true;
          }
        }

        if(outOfGuesses)
        {
          Console.Write("You Lose :(");
        }
        else
        {
          Console.Write("You Win!");
        }

        Console.ReadLine();
      }
    }
}
