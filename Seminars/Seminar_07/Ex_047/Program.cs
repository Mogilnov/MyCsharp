// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintMatrix (double [,] matr)
{
    for (int m=0; m<matr.GetLength(0); m++)
    {
        for (int n=0; n<matr.GetLength(1); n++)
        {
        Console.Write($"{matr[m,n]} ");
        }
    Console.WriteLine();
    }
}

void FillMatrix (double[,] matr)
{
    for (int m=0; m<matr.GetLength(0); m++)
    {
        for (int n=0; n<matr.GetLength(1); n++)
        {
        matr[m,n]= new Random ().Next(-10,10);
        }
    }
}

double[,] matrix = new double [3,4];

FillMatrix(matrix);
PrintMatrix(matrix);