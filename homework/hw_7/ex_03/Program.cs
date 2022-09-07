//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

void PrintOneArray(double[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]:f2} ");
    }
}

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
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

double[] FindAvg(int[,] matr)
{
    int countColumns = matr.GetLength(1);
    double[] arrayAvg = new double[countColumns];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        arrayAvg[j] = sum / matr.GetLength(0);
    }
    return arrayAvg;
}



int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
double[] array = FindAvg(matrix);
Console.WriteLine("Среднее арифмитическое столбцов: ");
PrintOneArray(array);