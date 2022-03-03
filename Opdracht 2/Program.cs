int[,] matrix = new int[3, 3];
int teller = 1;

//array vullen
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = teller;
        teller++;
    }
}

//array weergeven
int totaal = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{matrix[i, j]} ");

        totaal = totaal + matrix[i, j]; ;
    }
    Console.WriteLine();
}

Console.WriteLine($"Totaal: {totaal}");
