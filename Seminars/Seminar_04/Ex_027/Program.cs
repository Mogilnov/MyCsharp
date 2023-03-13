// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine ("Введите число N ");
int NumberN = Convert.ToInt16 (Console.ReadLine());

int SumDigits (int NumberN)
{
  int counter = Convert.ToString(NumberN).Length;
  int interim = 0;
  int result = 0;

  for (int i=0; i<counter; i++)
  {
  interim = NumberN - NumberN%10;
  result = result + (NumberN - interim);
  NumberN = interim/10;
  }
  return result;
}
int sumDigits = SumDigits(NumberN);
Console.WriteLine(sumDigits);


