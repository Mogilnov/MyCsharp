// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

double [,] array = new double [,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

void GetAverage (double [,] arr)
{
    double AvCol1 = (arr[0,0]+arr[1,0]+arr[2,0])/3;
    double a = Math.Truncate(10 * AvCol1) / 10;
    double AvCol2 = (arr[0,1]+arr[1,1]+arr[2,1])/3;
    double b = Math.Truncate(10 * AvCol2) / 10;
    double AvCol3 = (arr[0,2]+arr[1,2]+arr[2,2])/3;
    double c = Math.Truncate(10 * AvCol3) / 10;
    double AvCol4 = (arr[0,3]+arr[1,3]+arr[2,3])/3;
    double d = Math.Truncate(10 * AvCol4) / 10;
    Console.WriteLine($"Среднее арифметическое столбца 1 - {a}, столбца 2 - {b}, столбца 3 - {c}, столбца 4 - {d}");
}
GetAverage (array);