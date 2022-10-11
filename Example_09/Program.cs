using static System.Console;
Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

WriteLine("введите число : ");
int n10 = Convert.ToInt32(ReadLine()!);
WriteLine($"N2 = {N10toN2(n10)}");


string N10toN2 (int n10)
{
    string result = String.Empty;
    if (n10 == 0)
    {
        return "0";
    }
    while(n10 > 0){
        result = n10%2 + result;
        n10 = n10/2;
    }
    return result;
}










WriteLine("введите число : ");
int n10 = Convert.ToInt32(ReadLine()!);
WriteLine("введите основание : ");
int x = Convert.ToInt32(ReadLine()!);
WriteLine($"N2 = {N10toNX(n10, x)}");


string N10toNX (int n10, int x)
{
    string result = String.Empty;
    if (x >=10 && x <2 ){
        return "error";
    }
    if(n10==0){
        return "0";}    
    while(n10 > 0)
    {
        result = n10 % x + result;
        n10 = n10 / x;
    }
    return result;
}
