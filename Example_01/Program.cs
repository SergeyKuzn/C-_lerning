//////////////////////////////////////////////////////////////
// Задача №1. Первый код на C#

// Console.Write("Введите ваше имя");
// string username = Console.ReadLine();
// Console.WriteLine("Hello, ");
// Console.WriteLine(username);

//////////////////////////////////////////////////////////////
// Задача №2. Нахождение суммы + генератор случайных чисел
// int numberA = new Random().Next(1, 10); // генератор случайных чисел от 1 до 9
// int numberB = new Random().Next(1, 10);
// Console.WriteLine(numberA);
// Console.WriteLine(numberB);
// Console.WriteLine(numberA + numberB);

//////////////////////////////////////////////////////////////
// Задача №3. Нахождение частного
// double numberA = 12;
// double numberB = 5;
// Console.WriteLine(numberA / numberB);

//////////////////////////////////////////////////////////////
// Задача №4. Условный оператор If.
// Console.WriteLine("Введите имя пользователя");
// string username = Console.ReadLine();

// if (username.ToLower() == "маша"){
//     Console.WriteLine("Ура, это же МАША!");
// }
// else{
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }

//////////////////////////////////////////////////////////////
// Задача №5. Нахождение максимального числа.
// int a = 3;
// int b = 4;
// int c = 5;
// int d = 6;
// int e = 9;

// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;

// Console.Write("Максимальное число: ");
// Console.WriteLine(max);

//////////////////////////////////////////////////////////////
// Задача №6. Рисуем фигуру.
Console.Clear();

int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine('+');

Console.SetCursorPosition(xb, yb);
Console.WriteLine('+');

Console.SetCursorPosition(xc, yc);
Console.WriteLine('+');

int x = xa, y = xb;
int count = 0;

while(count < 10000)
{
    int want = new Random().Next(1, 3);
    if (want == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (want == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (want == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}