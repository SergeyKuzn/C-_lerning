using static System.Console;
Clear();
////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
    Задача 52. 
    Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Write("Введите число строк, столбцов, мин и макс значения в массиве: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = FillMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

PrintMatrix(matrix);
WriteLine();
ColumnAverage(matrix);


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

void ColumnAverage(int[,] inMatrix) 
{
    for (int j = 0; j < inMatrix.GetLength(1); j++) 
    {
        double average = 0;
        for (int i = 0; i < inMatrix.GetLength(0); i++)
        {
            average = average + inMatrix[i,j];
        }
        average = average/inMatrix.GetLength(1);
        WriteLine($"Среднее орифметическое {j+1}-го столбца = {average}");
    }
}