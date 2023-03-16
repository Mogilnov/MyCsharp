// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] M = new int[5];

void FillM (int[] array, int min, int max)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.WriteLine ("Введите число ");
        array[i] = Convert.ToInt16(Console.ReadLine());
    }
}

void PrintM (int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

int PositiveNumbers (int[] array)
{
    int count =0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}

FillM(M, -10, 1000);
PrintM(M);

int Count = PositiveNumbers(M);
Console.WriteLine ($"Количество положительных числе в массиве {Count}");
