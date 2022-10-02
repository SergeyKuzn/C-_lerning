using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

WriteLine("Задача выводит сумму чисел в заданном числе.");
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int summ = GetSumm(number);
WriteLine($"Сумма цифр в числе {number} = {summ}");

// описываем метод
int GetSumm(int num)
{
    int result = 0;                      
    while (num > 0)
    {
        result = result + num %10;
        num = num / 10;

    }
    return result;
}
