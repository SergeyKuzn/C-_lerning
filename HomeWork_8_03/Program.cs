using static System.Console;
Clear();
/////////////////////////////////////////////////////////////////////

/*
    Задача 58: 
    Задайте две матрицы. Напишите программу, которая будет находить 
    произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
*/

Write("input Matrix1 rows, columns, min val, max val: ");
int[] paramMatrix1 = GetArrayFromString(ReadLine()!);
int[,] matrix1Array = FillMatrixArray(paramMatrix1[0], paramMatrix1[1], paramMatrix1[2], paramMatrix1[3]);

Write("input Matrix2 rows, columns, min val, max val: ");
int[] paramMatrix2 = GetArrayFromString(ReadLine()!);
int[,] matrix2Array = FillMatrixArray(paramMatrix2[0], paramMatrix2[1], paramMatrix2[2], paramMatrix2[3]);

if (paramMatrix1[1] != paramMatrix2[0])
{
    WriteLine("Число столбцов в первой матрице, должно быть равно числу строк во второй матрице! \nВведите новые значения");
}
else
{
    PrintMatrix(matrix1Array);
    WriteLine();
    PrintMatrix(matrix2Array);
    int[,] resultMatrix = new int[paramMatrix1[0],paramMatrix2[1]];
    NewMatrixArray(matrix1Array, matrix2Array, resultMatrix);
    WriteLine($"Произведение первой и второй матриц:");
    PrintMatrix(resultMatrix);
}

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

int[] GetArrayFromString(string paramMatrix1)
{
    string[] parames = paramMatrix1
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

void NewMatrixArray(int[,] matrix1Array, int[,] matrix2Array, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1Array.GetLength(1); k++)
      {
        sum += matrix1Array[i,k] * matrix2Array[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}