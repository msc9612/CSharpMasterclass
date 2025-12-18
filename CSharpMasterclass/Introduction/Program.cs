// This is a simple C# program that prints "Hello, World!" to the console.

//Console.WriteLine("Hello, World!");


public partial class Program
{
    private static void Main(string[] args)
    {
        //takes the user input and prints it to the console
        //Variable with the name "userInput" of type string
        Console.WriteLine("Please enter your name:");
        string? userInput = Console.ReadLine();
        Console.WriteLine("You entered: " + userInput);
        Console.ReadKey();
    }
}