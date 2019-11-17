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


      // METHODS
      // A method is a block of code that we can call to perform a specific task
      // ToUpper()
      Console.WriteLine(phrase2.ToUpper());
      // ToLower()
      Console.WriteLine(phrase2.ToLower());
      // Contains()
      Console.WriteLine(phrase2.Contains("Academy"));
      // IndexOf()
      // Prints 8, because Academy begins at index position 8
      Console.WriteLine(phrase2.IndexOf("Academy"));
      Console.WriteLine(phrase2.IndexOf('f'));
      // Prints -1, because z does not exist within the string
      // -1 always indicates that something does not exist
      Console.WriteLine(phrase2.IndexOf('z'));
      // Substring
      // Allows us to grab a part of a string
      // Grabs the part of the string that begins at index 8
      Console.WriteLine(phrase2.Substring(8));
      // Can pass another parameter indicating how many characters we want to grab
      // Starts at index 8, prints 3 characters
      // Prints Aca
      Console.WriteLine(phrase2.Substring(8, 3));
      // Prints a capital G
      Console.WriteLine(phrase2[0]);


      // NUMBERS
      // Whole Numbers / Integers
      // Decimals
      // C# distinguishes between the two
      Console.WriteLine(40);
      // Performs a math operation
      // Prints 13
      Console.WriteLine(3 + 10);
      // Modulus
      // Prints 1
      Console.WriteLine(5 % 2);
      // Result is an integer
      // Decimals are omitted
      Console.WriteLine(5 / 2);
      // Result is in decimal form
      Console.WriteLine(5 / 2.0);
      // Store a number in a variable
      int num = 6;
      num++;
      Console.WriteLine(num);


      // MATH METHODS
      // Returns the absolute value of -40 which is 40
      Console.WriteLine(Math.Abs(-40));
      // Math.Pow
      // Power
      Console.WriteLine(Math.Pow(2, 2));
      // Math.Sqrt
      Console.WriteLine(Math.Sqrt(4));
      // Math.Max
      // Determines the larger of 2 numbers
      Console.WriteLine(Math.Max(4, 90));
      // Math.Min
      // Determines the smaller of 2 numbers
      Console.WriteLine(Math.Min(1, 2));
      // Math.Round
      Console.WriteLine(Math.Round(4.3));

    }
  }
}
