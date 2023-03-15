// адайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();


double[] numbers = new double[5];


void FillArray (double[] array, int min, int max)
{
   for (int i=0; i < array.Length; i++)
   {
       array[i] = new Random().Next(min, max);
   }
}


void PrintArray (double[] array)
{
   for (int i=0; i<array.Length; i++)
   {
       Console.Write(array[i] + " ");
   }
}


double Difference (double[] array)
{
       double dif = 0;
   for (int i=0; i<array.Length; i++)
   {
       double min = array[0];
       double max = array[0];
       if (array[i]<min) min=array[i];
       if (array[i]>max) max=array[i];
       dif = max-min;
   }


   return dif;
}


FillArray(numbers, 0, 100);
PrintArray(numbers);
Console.WriteLine();


double Dif = Difference(numbers);
Console.WriteLine ($"Разница между максимальным и минимальным элементами равна {Dif}");