
using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
    **Задача 53:** 
    Задайте двумерный массив. Напишите программу, 
    которая поменяет местами первую и последнюю строку массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    В итоге получается вот такой массив:
    8 4 2 4
    5 9 2 3
    1 4 7 2
*/

Write("Ввдеите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();
PrintMatrix(
        InvertArray(matrix));


int[,] GetMatrixArray(int rows,int columns,int minValue, int maxValue) 
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) 
        {
            resultMatrix[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix) 
{
    for (int i = 0; i < inMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]}\t");
        }
        WriteLine();
    }
}

int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[parames.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]= Convert.ToInt32(parames[i]);
    }
    return result;
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