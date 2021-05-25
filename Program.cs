using System;

Console.WriteLine("Lets play a game!");
Console.WriteLine("Please guess the secret number!");
Console.WriteLine("");

Console.Write("Your guess> ");
string number = Console.ReadLine();

if (string.IsNullOrWhiteSpace(number))
{
    Console.WriteLine("Your loss, this game is fun!");
}
else
{
    Console.WriteLine($"You guessed {number}");
}