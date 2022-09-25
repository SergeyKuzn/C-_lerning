// Лекция №2. Знакомство с функциями и массивами

///////////////////////////////////////////////////////////////
// Задача №1. Нахождение максимума из 9 чисел с помощью функции.

int a1 = 4;
int b1 = 5;
int c1 = 45;
int a2 = 46;
int b2 = 8890;
int c2 = 49;
int a3 = 54;
int b3 = 41;
int c3 = 45;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine($"Максимальное число: {max}");
 