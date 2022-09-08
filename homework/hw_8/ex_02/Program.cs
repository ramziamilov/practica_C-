// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int FindIndexRowsMinSum(int[,] matrix)
{
    int indexRow = 0;
    int minRowSum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexRow = i + 1;
        }
    }
    return indexRow;
}


int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
int indexMin = FindIndexRowsMinSum (matrix);
System.Console.WriteLine($"строка с наименьшей сумма - {indexMin}");
