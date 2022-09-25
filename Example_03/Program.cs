﻿//Лекция 3. 


///////////////////////////////////////////////////////////////////////////////
// Задача 1. Цикл For. Таблица умножения
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


////////////////////////////////////////////////////////////////////////////////
// Задача 2.
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
// маленькими “с”.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого " 
//             + "Винценгероде, вы бы взяли приступом согласие "
//             + "прусского короля. Вы так красноречивы. Вы "
//             + "дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

////////////////////////////////////////////////////////////////////////////////
// Задача 3. Сортирповка массива

int[] arr = {11, 38, 43, 5, 6, 8, 9, 6, 43, 10, 34, 56};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
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

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);