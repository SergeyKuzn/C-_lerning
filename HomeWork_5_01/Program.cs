using static System.Console;
Clear();
////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 34: 
////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Write("Задайте длину массива: ");
int arrayLenght = int.Parse(ReadLine()!);

Write("Задайте минимальное значение: ");
int minValue = int.Parse(ReadLine()!);

Write("Задайте максимальное значение: ");
int maxValue = int.Parse(ReadLine()!);

int[] array = GetArray(arrayLenght, minValue, maxValue);
string strArray = string.Join(" | ", array);
WriteLine($" [{strArray}] ");

int countPozitiveNumber = 0;
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        countPozitiveNumber++;
    }
}
WriteLine($"Количество четных чисел в массиве = {countPozitiveNumber}");


// Описываем метод
int[] GetArray(int arrayLenght, int minValue, int maxValue)
{
    int[] result = new int[arrayLenght];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}








