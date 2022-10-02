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

WriteLine("Введите длину массива: ");
int l = int.Parse(ReadLine()!);
int[] array = GetBinaryArray(l);
PrintArray(array);
WriteLine($"Количество нулей в массиве равно {ZeroCount(array)}");

int[] GetBinaryArray(int length)
{
    Random rnd = new Random();
    int[] result = new int[length];
    for (int i = 0; i < length-1; i++)
    {
        result[i] = rnd.Next(0,2);
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

int ZeroCount(int[] inArray)
{
    int result = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i]==0) result++;
    }
    return result;
}
