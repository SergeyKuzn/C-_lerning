using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Одномерные массивы и методы (закрепление)
////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 39:
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


Write("Введите размер массива, мин и макс значение через пробел: ");
string[] parameters = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
string strArray = string.Join(" | ", array);
WriteLine($" [{strArray}] ");

//ReverseArray(array);

WriteLine($" [{string.Join(" , ",ReverseArray(array))}] ");



int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}


int[] ReverseArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}