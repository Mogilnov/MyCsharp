string[,] table = new string [2,5];
table[1,2] = "слово";

for (int row=0; row<2; row++)
{
    for (int column=0; column<5; column++)
    {
        Console.Write($"-{table[row, column]}-");
    }
    Console.WriteLine();
}
