using static System.Console;
Clear();
/////////////////////////////////////////////////////////////////////

/*
    Задача 56: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку 
    с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и 
    выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Write("input rows, columns, min val, max val: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrixArray = FillMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrixArray);
WriteLine();

int minSumRowNumber = 1;
int sumInRow = SumInRow(matrixArray, 0);
for (int i = 1; i < matrixArray.GetLength(0); i++)
{
    int temp = SumInRow(matrixArray, i);
    if (sumInRow>temp)
    {
        sumInRow = temp;
        minSumRowNumber = i+1;
    }
}

WriteLine($"{minSumRowNumber}");


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

int SumInRow(int[,] inMatrix, int i) 
{
    int summ = inMatrix[i,0];
    for (int j = 1; j < inMatrix.GetLength(1); j++)
    {
        summ = summ + inMatrix[i,j];
    }
    WriteLine($"Сумма значений в строке {i+1} = {summ}.");
    return summ;
}


