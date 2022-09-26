﻿using static System.Console;
Clear();

/////////////////////////////////////////////////////////////////////////////////////////
// Методы в программировании
/////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Write("Введите число: ");
// int a = int.Parse(ReadLine()!);
// int sum = GetSum(a);
// WriteLine($"Сумма чисел от 1 до {a} = {sum}");

// int GetSum(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number;
//         number--;
//     }
//     return result;
// }



/////////////////////////////////////////////////////////////////////////////////////////
// **Задача 26:**
// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
int nc = NumberCount(a);
WriteLine($"Количество цифр в числе {a} = {nc}");

int NumberCount (int number)
{
    int result = 0;
    if (number == 0){
        result = 1;
        return result;

    }
    while (number > 0)
    {
        number /= 10;
        result++; 
    }
    return result;
}

/////////////////////////////////////////////////////////////////////////////////////////
// **Задача 28:**
// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

// Write("Введите число: ");
// int a = int.Parse(ReadLine()!);
// int fib = GetFib(a);
// WriteLine($"Произведение чисел от 1 до {a} = {fib}");


// int GetFib (int number)
// {
//     int result = 1;
//     int i = 1;
//     while (i <= number)
//     {
//         result = result * i;
//         i++;
//     }
//     return result;
// }
