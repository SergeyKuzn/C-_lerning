using static System.Console;
Clear();
////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
    Задача 41: 
    Пользователь вводит с клавиатуры M чисел. Посчитайте, 
    сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/
Write("Ввдеите любые цифры: ");
int[] array = GetArrayFromString(ReadLine()!);
printArray(array);

int countPositiveNumbers = 0;
foreach (int item in array)
{
    if (item > 0) countPositiveNumbers++;
}
WriteLine($"Вы ввели {countPositiveNumbers} цифр, которые больше 0.");

int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters
                    .Replace(",", " ")
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[parames.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]= Convert.ToInt32(parames[i]);
    }
    return result;
}

void printArray(int[] array)
{
    string FinalString = "[ ";
    foreach (int item in array)
    {
        FinalString+=$"{item} ";
    }
    FinalString += " ]";
    WriteLine(FinalString);
}

