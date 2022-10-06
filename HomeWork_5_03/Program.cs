using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 38:  
////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Write("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
Write("Введите MIN значение: ");
int minValue = Convert.ToInt32(ReadLine());
Write("Введите MAX значение: ");
int maxValue = Convert.ToInt32(ReadLine());
double[] array = GetArray(size, minValue, maxValue);
WriteLine($"[{string.Join(" | ", array)}] ");
WriteLine($"Максимальное число в массиве = {FindMax(array)}");
WriteLine($"Минимальное число в массиве = {FindMin(array)}");
WriteLine($"Разница между мин и макс элементами массива = {FindMax(array) - FindMin(array)}");

double[] GetArray(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue ) + Math.Round(rnd.NextDouble(), 2);
    }
    return array;
}

double FindMax(double[] myArray)
{
    double maxValue = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
    if (myArray[i] > maxValue)
        {
            maxValue = myArray[i];
        }
    }
    return maxValue;
}

double FindMin(double[] myArray)
{
    double minValue = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {

        if (myArray[i] < minValue)
        {
            minValue = myArray[i];
        }
    }
    return minValue;
}