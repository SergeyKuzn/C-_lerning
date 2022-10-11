using static System.Console;
Clear();
////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
    Задача 50. 
    Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет
*/

Write("Введите число строк, столбцов, мин и макс значения в массиве: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = FillMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

PrintMatrix(matrix);
WriteLine();

Write("Введите номер столбца выбранного элемента: ");
int column = Convert.ToInt32(ReadLine()!);
Write("Введите номер строки выбранного элемента: ");
int row = Convert.ToInt32(ReadLine()!);

if (column > matrix.GetLength(1) || row > matrix.GetLength(0)) 
                WriteLine("Такого элемента нет!");
else
                WriteLine($"Значение указанного элемент: {matrix[row-1,column-1]}");


int[,] FillMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < resultMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) 
        {
            resultMatrix[i,j] = rnd.Next(minValue, maxValue );
        }
    }
    return resultMatrix;
}

int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters
                    .Replace(",", " ")
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[parames.Length];
    if(parames.Length != 4) WriteLine("Введите 4 значения!");
    for (int i = 0; i < result.Length; i++)
    {
        result[i]= Convert.ToInt32(parames[i]);
    }
    return result;
}

void PrintMatrix(int[,] inMatrix) 
{
    for (int i = 0; i < inMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    }
}



