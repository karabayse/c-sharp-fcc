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


      // CORE DATA TYPES

      // Use string for more than 1 character
      string phrase = "Giraffe Academy";

      // char can only contain 1 character
      // char grade = 'ABCD' will not work
      char grade = 'A';

      // An integer is a whole number
      // An integer contains no decimals
      int age = 70;

      // 3 different data types that can store/represent decimal numbers:
      // float (least precise), double, decimal (most precise)
      double gpa = 3.2;
      // could do:
      double gpa = 3.0;
      // but need to include the decimal point

      // Boolean
      bool isFemale = true;


      // STRINGS
      Console.WriteLine("Giraffe Academy");
      // Write to a new line
      Console.WriteLine("Giraffe\nAcademy");
      // Print a quotation mark
      Console.WriteLine("Giraffe\"Academy");
      // Use a variable
      string phrase = "Giraffe Academy";
      Console.WriteLine(phrase);
      // Concatenation
      string phrase2 = "Giraffe Academy" + " is cool";
      Console.WriteLine(phrase2);
      // Length property
      Console.WriteLine(phrase2.Length);
    }
  }
}
