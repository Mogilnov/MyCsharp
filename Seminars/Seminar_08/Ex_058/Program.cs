// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

int[,] array1 = new int[,]
{
    {2, 4},
    {3, 2},
};

int[,] array2 = new int[,]
{
    {3, 4},
    {3, 3},
};

int[,] resultArray = new int[2,2];

void MultiplyArray(int[,] array1, int[,] array2, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

MultiplyArray(array1, array2, resultArray);
Console.WriteLine($"\nПроизведение первой и второй матриц: ");
WriteArray (resultArray);
