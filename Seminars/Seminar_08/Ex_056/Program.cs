// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[,]
{
    {1, 4, 7, 3},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7},
};

int SumRow(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

int minRow = 0;
int sumRow = SumRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumRow(array, i);
  if (sumRow > tempSum)
  {
    sumRow = tempSum;
    minRow = i;
  }
}

Console.WriteLine($"Cтрокa с наименьшей суммой элементов - \n{minRow+1}");