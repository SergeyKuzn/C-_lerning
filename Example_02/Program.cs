﻿// Лекция №2. Знакомство с функциями и массивами

///////////////////////////////////////////////////////////////
// Задача №1. Нахождение максимума из 9 чисел с помощью функции.

// int a1 = 4;
// int b1 = 5;
// int c1 = 45;
// int a2 = 46;
// int b2 = 8890;
// int c2 = 49;
// int a3 = 54;
// int b3 = 41;
// int c3 = 45;

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Console.WriteLine($"Максимальное число: {max}");

////////////////////////////////////////////////////////////////////
// Задача №2. Нахождение максимума из 9 чисел с массивами.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {12, 34, 456, 435, 1243, 4356, 9546, 76, 143};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);