using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
        Задача 57: Составить частотный словарь элементов двумерного массива. 
        Частотный словарь содержит информацию о том, сколько раз встречается 
        элемент входных данных.
        1, 2, 3
        4, 6, 1
        2, 1, 6

        1 встречается 3 раза
        2 встречается 2 раз
        3 встречается 1 раз
        4 встречается 1 раз
        6 встречается 2 раза
*/

Write("Ввдеите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();
int[] newArray = OneLineArray(matrix);
PrintArray(newArray);
SelectionSort(newArray);
WriteLine();
PrintArray(newArray);
WriteLine();
PrintLibra(newArray);



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

void PrintArray(int[] inMatrix) 
{
    Write("[");
    for (int i = 0; i < inMatrix.Length; i++) 
    {
        Write($"{inMatrix[i]}, ");
    }
    Write("]");
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

int[] OneLineArray(int[,] Array)
{
    int[] line = new int[Array.GetLength(0) * Array.GetLength(1)];
    int count = 0;
    foreach (int item in Array)
    {
        line[count] = item;
        count++;
    }
    return line;
}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temt = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temt;
    }
}

void PrintLibra(int[] inArray)
{
    int number = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[i] == number) 
        {
            count++;
        }
        else
        {
            WriteLine($"В матрице {number} число встрчается {count} раз.");
            count = 1;
            number = inArray[i];
        }
    }
    WriteLine($"В матрице {number} число встрчается {count} раз.");
}