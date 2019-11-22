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
      // Get first number
      Console.Write("Enter a number: ");
      // Use Convert to convert from a string to an integer
      double num1 = Convert.ToDouble(Console.ReadLine());

      // Get the operator
      Console.Write("Enter Operator: ");
      string op = Console.ReadLine();

      // Get second number
      Console.Write("Enter a number: ");
      // Use Convert to convert from a string to an integer
      double num2 = Convert.ToDouble(Console.ReadLine());

      if (op == "+") {
        Console.WriteLine(num1 + num2);
      } else if (op == "-") {
        Console.WriteLine(num1 - num2);
      } else if (op == "*") {
        Console.WriteLine(num1 * num2);
      } else if (op == "/") {
        Console.WriteLine(num1 / num2);
      } else {
        Console.WriteLine("Invalid Operator");
      }
        Console.ReadLine();
      }
    }
  }
