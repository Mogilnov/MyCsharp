﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] numbers = new int [4];

void FillArray (int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray (int[] array)
{ 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int EvenNumbers (int[] array)
{
    int even = 0;
    for (int i=0; i<array.Length; i++)
    {
     if (array[i]%2 == 0)
        even++;
        
    }
    return even;
}

FillArray(numbers, 100, 1000);
PrintArray(numbers);
Console.WriteLine();

int evenNumbers = EvenNumbers(numbers);
Console.WriteLine($"Количество чётных чисел в массиве {evenNumbers}");
