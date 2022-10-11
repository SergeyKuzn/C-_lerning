using static System.Console;
Clear();


// **Задача 48:** 

int count = 0;

do
{
    Write("Input number: ");
    if (int.Parse(ReadLine()!) > 0) count++;
    WriteLine($"Positive numbers = {count}");
    WriteLine("Continue? Yes - enter, No - any key");
} while (ReadKey().Key==ConsoleKey.Enter);
