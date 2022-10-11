using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// **Задача 44:** 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int n = Convert.ToInt32(ReadLine()!);

int[] Fibonacci = new int[n];
Fibonacci[0] = 0;
Fibonacci[1] = 1;
for (int i = 0; i < n; i++)
{
    Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i-2];
}
WriteLine(string.Join(", ", Fibonacci));
