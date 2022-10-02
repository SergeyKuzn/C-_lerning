using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// **Задача 31:** 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// Write("Введите размер массива: ");
// int lenght = int.Parse(ReadLine()!);
// Write("Введите минимальное значение массива: ");
// int min = int.Parse(ReadLine()!);
// Write("Введите максимальное значение массива: ");
// int max = int.Parse(ReadLine()!);
// int[] array = GetArray(lenght, min, max);
// string strArray = string.Join(" ",array);
// WriteLine($"[{strArray}]");

// int positivSum = 0;
// int negativSum = 0;
// foreach (int element in array)
// {
//     if (element > 0)
//     {
//         positivSum += element;
//     }
//     if (element < 0)
//     {
//         negativSum += element;
//     }
// }
// WriteLine($"positive = {positivSum}, negative = {negativSum}");


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     int[] result = new int[size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }


////////////////////////////////////////////////////////////////////////////////////////////////////////////
// **Задача 32:** 
// Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


WriteLine("Введите длину массива ");
int a= int.Parse(ReadLine()!);
int[] array = getArray(a);
printArray(array);
changeArray(array);
printArray(array);

int[] getArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
     result[i] = new Random().Next(-10,11);
    
    }
    return result;
}

void changeArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = array2[i]*-1;
    }
}

void printArray(int[] array3)
{
    string FinalString = "[ ";
    foreach (int item in array3)
    {
        FinalString+=$"{item} ";
    }
    FinalString += " ]";
    WriteLine(FinalString);
}












// **Задача 33:** 
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



// **Задача 35:** 
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// **Задача 37:** 
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
