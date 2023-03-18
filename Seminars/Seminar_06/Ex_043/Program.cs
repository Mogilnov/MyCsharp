// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double a = SetValue ("b1");
double b = SetValue ("k1");
double c = SetValue ("b2");
double d = SetValue ("k2");

double SetValue (string NumberValue)
{
    Console.WriteLine ($"Введите значение {NumberValue}");
    return Convert.ToInt16(Console.ReadLine());
}

double CrossPointY (double a, double b, double c, double d)
{
    double y = 0;
    y = (c*b-a*d)/(b-d);
    return y;
}

double CrossPointX (double a, double b, double c, double d)
{
    double x = 0;
    x = (c-a)/(b-d);
    return x;
}

double CrossY = CrossPointY (a, b, c, d);
double CrossX = CrossPointX (a, b, c, d);
Console.WriteLine ($"Точка прересечения {CrossY} {CrossX}");


