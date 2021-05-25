using System;

Console.WriteLine("Lets play a game!");
Console.WriteLine("Please guess the secret number!");
Console.WriteLine("");

int secretNumber = new Random().Next(1, 100);
int attempts = 6;
Main();

void Main()
{
    Console.Write("Your guess> ");
    int number = int.Parse(Console.ReadLine());

    if (number == secretNumber && attempts > 0)
    {
        Console.WriteLine($"Your guess of {number} is CORRECT!");
    }
    else if (number != secretNumber && attempts == 0)
    {
        Console.WriteLine($"WRONG!!! Guesses Remaining {attempts}, no more guesses.");
    }
    else
    {
        string highLow = number > secretNumber ? "Too High!" : "Too Low!";
        Console.WriteLine($"{highLow} {number} is incorrect... YOU SUCK! (Guesses remaining {attempts})");
        attempts--;
        Main();
    }
}
