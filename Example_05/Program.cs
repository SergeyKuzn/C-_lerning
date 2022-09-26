using static System.Console;
Clear();

/////////////////////////////////////////////////////////////////////////////////////////
// Массивы в программировании
/////////////////////////////////////////////////////////////////////////////////////////



/////////////////////////////////////////////////////////////////////////////////////////
// Задача 
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// Напишите метод, который считает количесвто нулей в бинарном массиве
// [1,0,1,1,0,1,0,0]

//int[] array = {};
//int[] array2 = new int[4];

Write("Введите длину массива ");
int l = int.Parse(ReadLine()!);
int[] array = GetBinaryArray(l);
PrintArray(array);
WriteLine($"Количество нолей в массиве {ZeroCount(array)}");




int[] GetBinaryArray(int lenght)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght - 1; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[ ");
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write("\b ");
    WriteLine("]");
}

int ZeroCount(int[] InArray)
{
    int result = 0;
    for (int i = 0; i < InArray.Length; i++)
    {
        if(InArray[i] == 0) result++;
    }
    return result;
}

/////////////////////////////////////////////////////////////////////////////////////////
// Задача 







/////////////////////////////////////////////////////////////////////////////////////////
// Задача 