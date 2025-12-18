//create an instance of Random
class GuessANumbers
{
    static void Main(string[] args)
    {
        GuessANumbers game = new GuessANumbers();
        Random random = new Random();
        int guessCount = 0;

        Console.WriteLine("Enter a number between 1 and 10");

        string inputString = Console.ReadLine();
        int input = int.Parse(inputString);
        int randomNumber = random.Next(1, 11);
        while (guessCount < 3 && input != randomNumber)
            {
                if (input < randomNumber)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else
                {
                    Console.WriteLine("Too high, try again.");
                }
                inputString = Console.ReadLine();
                input = int.Parse(inputString);
                guessCount++;
            }
            if (input == randomNumber)
            {
                Console.WriteLine("Congratulations, you guessed the number!");
            }
            else
            {
                Console.WriteLine("Sorry, you've used all your guesses. The number was " + randomNumber);
            }
    }
    
}

