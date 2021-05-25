using System;

Console.WriteLine("Lets play a game!");
Console.WriteLine("Please guess the secret number!");
Console.WriteLine("");

Console.Write("Your guess> ");
string number = Console.ReadLine();

string secretNumber = "42";

if (string.IsNullOrWhiteSpace(number))
{
    Console.WriteLine("Your loss, this game is fun!");
    return;
}
else if (number == secretNumber)
{
    Console.WriteLine($"Your guess of {number} is CORRECT!");
}
else
{
    Console.WriteLine($"{number} is incorrect... YOU SUCK!");
}



// if (number == secretNumber)
// {
//     Console.WriteLine($"Your guess of {number} is CORRECT!");
// }
// else
// {
//     Console.WriteLine($"{number} is incorrect... YOU SUCK!");
// }