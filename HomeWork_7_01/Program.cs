using static System.Console;
Clear();
////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
    Задача 47. 
    Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/


Write("Введите число строк, столбцов, мин и макс значения в массиве: ");
int[] parameters = GetArrayFromString(ReadLine()!);
double[,] matrix = FillMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
double wer = 2.5;
WriteLine(wer.GetType());

double[,] FillMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] resultMatrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < resultMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) 
        {
            resultMatrix[i,j] = rnd.Next(minValue, maxValue ) + Math.Round(rnd.NextDouble(), 2);
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

void PrintMatrix(double[,] inMatrix) 
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