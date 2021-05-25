using System;

Console.WriteLine("Lets play a game!");
Console.WriteLine("Please guess the secret number!");
Console.WriteLine("");

int attempts = 6;
Main();

void Main()
{
    int secretNumber = new Random().Next(1, 100);

    Console.Write("Your guess> ");
    string number = Console.ReadLine();
    int guess = int.Parse(number);

    if (string.IsNullOrWhiteSpace(number))
    {
        Console.WriteLine("Your loss, this game is fun!");
        return;
    }
    else if (guess == secretNumber && attempts > 0)
    {
        Console.WriteLine($"Your guess of {number} is CORRECT!");
    }
    else if (guess != secretNumber && attempts == 0)
    {
        Console.WriteLine($"WRONG!!! Guesses Remaining {attempts}, no more guesses.");
    }
    else
    {
        Console.WriteLine($"{number} is incorrect... YOU SUCK! (Guesses remaining {attempts})");
        attempts--;
        Main();

    }
}
