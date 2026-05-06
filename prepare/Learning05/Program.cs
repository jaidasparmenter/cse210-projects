using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    // Main function
    static void Main(string[] args)
    {
        DisplayWelcome();

       string User = PromptUserName();
       double number = PromptUserNumber();
       int birthyear;
       PromptUserBd(out birthyear);

       double square = SquareNumber(number);
       

       DisplayResult(User, square, birthyear);

    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        return Console.ReadLine();
    }

    static double PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return double.Parse(Console.ReadLine());
    
    }

    static void PromptUserBd(out int birthyear)
    {
        Console.Write("What is your birthyear? ");
        birthyear =  int.Parse(Console.ReadLine());
    }

    static double SquareNumber(double number)
    {
        return number * number;
    }
    
    static void DisplayResult(string user, double square, int birthyear)
    {
        int age = 2026 - birthyear;
        Console.WriteLine($"{user}, the square of your number is {square}.");
        Console.WriteLine($"{user}, you are turning {age} this year.");
    }


}
