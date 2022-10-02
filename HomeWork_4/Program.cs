using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Write("Введите произвольное целое число (Число 1): ");
int number = int.Parse(ReadLine()!);
Write("Введите произвольное целое число, в какую степень будем возводить число 1: ");
int numberPow = int.Parse(ReadLine()!);
int Pow = GetPow(number, numberPow);
WriteLine($"Число {number} в степени {numberPow} равно {Pow}");

// Пишем метод
int GetPow(int num, int numPow)
{
    int result = 1;
    for (int i = 0; i < numPow; i++)
    {
        result = result * num;
    }
    return result;
}



