using static System.Console;
Clear();
/////////////////////////////////////////////////////////////////////

/*
    Задача 54: 
    Задайте двумерный массив. Напишите программу, которая 
    упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
*/


Write("input rows, columns, min val, max val: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrixArray = FillMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

PrintMatrix(matrixArray);
WriteLine();
RowSort(matrixArray);
PrintMatrix(matrixArray);

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

void RowSort(int[,] inMatrix) 
{
    for (int i = 0; i < inMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix.GetLength(1) - 1; k++)
            {
                if(inMatrix[i,k+1] < inMatrix[i,k])
                {
                    int temp = inMatrix[i,k+1];
                    inMatrix[i,k+1] = inMatrix[i,k];
                    inMatrix[i,k] = temp;
                };
            }
        }    
    }
}


