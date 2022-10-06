using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 36:  
////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Write("Задайте длину массива: ");
int arrayLenght = int.Parse(ReadLine()!);
Write("Задайте минимальное значение: ");
int minValue = int.Parse(ReadLine()!);
Write("Задайте максимальное значение: ");
int maxValue = int.Parse(ReadLine()!);
int[] array = GetArray(arrayLenght, minValue, maxValue);
string strArray = string.Join(" | ", array);
WriteLine($" [{strArray}] ");

int getSumm = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        getSumm = getSumm + array[i];
    }
}
WriteLine($"сумму элементов, стоящих на нечётных позициях = {getSumm}");

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