using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник со сторонами такой длины.

WriteLine(" стороны a, b, c: ");
string [] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int a = Convert.ToInt32(parameters[0]);
int b = Convert.ToInt32(parameters[1]);
int c = Convert.ToInt32(parameters[2]);
string result = "не треугольник";
if( a+b>c && b+c>a && a+c>b){
    result = "треугольник";
}
WriteLine(result);
