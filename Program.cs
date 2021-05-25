using System;

Console.WriteLine("Lets play a game!");
Console.WriteLine("Please guess the secret number!");
Console.WriteLine("");

int attempts = 1;
Main();

void Main()
{
    string secretNumber = "42";

    Console.Write("Your guess> ");
    string number = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(number))
    {
        Console.WriteLine("Your loss, this game is fun!");
        return;
    }
    else if (number == secretNumber && attempts < 4)
    {
        Console.WriteLine($"Your guess of {number} is CORRECT!");
    }
    else if (number != secretNumber && attempts == 4)
    {
        Console.WriteLine($"WRONG!!! Atempt number {attempts}, no more guesses.");
    }
    else
    {
        Console.WriteLine($"{number} is incorrect... YOU SUCK! (attempt number {attempts})");
        attempts++;
        Main();

    }
}

// I already completed phase 4 in phase 3... oops
