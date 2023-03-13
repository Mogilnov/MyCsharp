// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine ("Введите число A ");
int A = Convert.ToInt16(Console.ReadLine());
Console.WriteLine ("Введите число B ");
int B = Convert.ToInt16(Console.ReadLine());

for (int i=0; i<1; i++)
{
    int exponent = (int)(Math.Pow(A, B));
    Console.WriteLine(exponent);
}
