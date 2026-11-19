using System;

public class Program
{
    public static void Main()
    {
         // Ask for the user's name
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
         // Ask for the user's age
        Console.Write("How old are you? ");
        string age = Console.ReadLine();
         // Display a personalized message that includes both pieces of information
        Console.WriteLine(new string('-', 20)); Console.WriteLine($"Hello, {name}! \nYou are {age} years old."); Console.WriteLine(new string('-', 20));
    }
}
