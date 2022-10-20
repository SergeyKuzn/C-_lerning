using static System.Console;
Clear();
/////////////////////////////////////////////////////////////////////

/*
    Задача 66: 
    Задайте значения M и N. Напишите программу, 
    которая найдёт сумму натуральных элементов 
    в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

int a = 4;
int b = 8;

WriteLine(SummNumber(a, b));



int SummNumber(int a, int b)
{
    if (a == b)
        return b;
    return b + SummNumber(a, b - 1);
}

