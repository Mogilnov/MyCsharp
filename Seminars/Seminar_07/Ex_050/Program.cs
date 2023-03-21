// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int [,] array = new int [,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

void GetValue (int [,] arr)
{
Console.WriteLine ("Введите номер столбца массива (макс. 4) ");
int col = Convert.ToInt16(Console.ReadLine()) -1;
Console.WriteLine ("Введите номер строки массива (мкс. 3) ");
int row = Convert.ToInt16(Console.ReadLine()) -1;
if (col >3 || row > 2)
{
Console.WriteLine ("Такого элемента нет. Введите номер столбца не более 4 и строки не более 3");
}
else
Console.Write ($"Значение элемена: {arr[row,col]}");
Console.WriteLine();
}

GetValue(array);
