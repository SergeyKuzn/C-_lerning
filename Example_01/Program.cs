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
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша"){
    Console.WriteLine("Ура, это же МАША!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}