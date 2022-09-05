// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве неn


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
            matr[i, j] = new Random().Next(-100, 100);
        }
    }
}

void ReturnPositionMatrix(int[,] matr, int rowsPosition, int columnsPosition)
{
    int i = rowsPosition - 1;
    int j = columnsPosition - 1;

    if (i < 0 || i > matr.GetLength(0)
    || j < 0 || j > matr.GetLength(1))
    {
        Console.WriteLine("такого элемента нет!");
    }
    else
    {
        Console.WriteLine($"значение выбранного элемента массива: {matr[i, j]} ");
    }

}

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
int rowsPosition = Prompt("Введите номер строки элемента: ");
int columnsPosition = Prompt("введите номер столбца элемента: ");
ReturnPositionMatrix(matrix, rowsPosition, columnsPosition);
