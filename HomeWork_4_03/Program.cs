using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Write("Задайте длину массива: ");
int arrayLenght = int.Parse(ReadLine()!);

Write("Задайте минимальное значение: ");
int minValue = int.Parse(ReadLine()!);

Write("Задайте максимальное значение: ");
int maxValue = int.Parse(ReadLine()!);

int[] array = GetArray(arrayLenght, minValue, maxValue);
string strArray = string.Join(" | ", array);
WriteLine($" [{strArray}] ");

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