// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: " );
int a = Convert.ToInt32(Console.ReadLine());

int SecondDigit = (a%100 - a%10)/10;

Console.WriteLine (SecondDigit);