using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(ReadLine());

// int a1 = number / 10000;
// int a2 = number / 1000 - a1 * 10;
// int a5 = number % 10;
// int a4 = (number % 100 - a5) / 10;

// // WriteLine($"Число а1 = {a1}"); 
// // WriteLine($"Число а2 = {a2}"); 
// // WriteLine($"Число а4 = {a4}"); 
// // WriteLine($"Число а5 = {a5}"); 

// if (a1 == a5 && a2 == a4)
// {
//     WriteLine($"Число {number} является полиндромом.");
// }
// else 
// {
//     WriteLine($"Число {number} не является полиндромом.");
// }


/////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// WriteLine("Введите координаты точки № 1 по осям: ");
// Write("По оси Х: ");
// double x1 = Convert.ToInt32(ReadLine());
// Write("По оси Y: ");
// double y1 = Convert.ToInt32(ReadLine());
// Write("По оси Z: ");
// double z1 = Convert.ToInt32(ReadLine());

// WriteLine("Введите координаты точки № 2 по осям: ");
// Write("По оси Х: ");
// double x2 = Convert.ToDouble(ReadLine());
// Write("По оси Y: ");
// double y2 = Convert.ToDouble(ReadLine());
// Write("По оси Z: ");
// double z2 = Convert.ToDouble(ReadLine());

// double distance = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) 
//                 + Math.Pow((y2 - y1), 2) 
//                 + Math.Pow((z2 - z1), 2)), 2);

// WriteLine($"Расстояние между точками №1 и №2 в 3D пространстве = {distance}");



/////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 23
// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Write("Введите положительное целое число: ");
double number = Convert.ToInt32(ReadLine());

WriteLine($"Таблица кубов чисел от 1 до {number}:");
for (double i = 1; i <= number; i++)
{
    Write($"{Math.Pow(i, 3)} ");
}