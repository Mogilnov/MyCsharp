﻿// Напишите метод(-ы), который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int N = cubeTable (" ");
int cubeTable (string lastNumber)
{
Console.Write ($"Введите число {lastNumber} ");
return Convert.ToInt16(Console.ReadLine());
}
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow (i, 3));
}
