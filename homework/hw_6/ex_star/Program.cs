//Двумерный массив с рандомными числами

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // количесвто строк 2, поэтому <2!
    {
        for (int j = 0; j < matr.GetLength(1); j++) // количество столбцов
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 100); // [0; 99]
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);