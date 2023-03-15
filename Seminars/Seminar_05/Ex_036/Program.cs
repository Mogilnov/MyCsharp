// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOdds (int[] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
     if (i%2 == 1)
        sum = sum + array[i];
        
    }
    return sum;
}

FillArray(numbers, -100, 100);
PrintArray(numbers);
Console.WriteLine();

int oddsSum = SumOdds(numbers);
Console.WriteLine($"Сумма элементов на нечётных позициях массива {oddsSum}");

