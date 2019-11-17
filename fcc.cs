// Commands that configure the file
using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
States that we are in the Giraffe project
Within the Visual Studio IDE, this would match the project name
*/
namespace Giraffe
{
  // The class is a container where we can store a bunch of code
  class Program
  {
    /*
    Main is a method or function
    This is another container where we can put code
    This is where we put the code that we want to execute
    This code gets executed when we run the Program
    This code runs automatically
    */
    static void Main(string[] args)
    {
      // This line writes to the console
      Console.WriteLine("Hello, World!");
      // This line keeps the console window up
      Console.ReadLine();

      // Variable
      // A variable is a data store
      string characterName = "John";
      // Declares the variable without giving it a value
      int characterAge;
      // Assigns a value to the variable
      characterAge = 35;

      Console.WriteLine("There once was a man name " + characterName);
      Console.WriteLine("He was " + characterAge + " years old");
      characterName = "Tom";
      Console.WriteLine("He really like the name " + characterName);
      Console.WriteLine("But he didn't like being " + characterAge);
    }
  }
}
