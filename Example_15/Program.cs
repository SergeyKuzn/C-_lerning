using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
    **Задача 55:** 
    Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
    В случае, если это невозможно, программа должна вывести сообщение для пользователя.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    В итоге получается вот такой массив:
    1 5 8 5
    4 9 4 2
    7 2 2 6
    2 3 4 7
*/

Write("введите размер матрицы и минимальный и максимальное значение через пробел: ");
int[] parametrs = GetArrayFromString(ReadLine());
int[,] matrix = GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);
WriteLine();
PrinttMatrix(InvertArray(matrix));









int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultMatrix;
}

void PrinttMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} ");
        }
        WriteLine();
    }
}
int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}

int[,] InvertArray(int[,] inArray)
{


    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int temp = inArray[0, j];
        inArray[0, j] = inArray[inArray.GetLength(0) - 1, j];
        inArray[inArray.GetLength(0) - 1, j] = temp;

    }
    return inArray;
}