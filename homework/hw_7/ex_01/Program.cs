﻿// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            Console.Write($"{matr[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = (double)rnd.NextDouble()*10; 
        }
    }
}

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
double[,] matrix = new double[rows, columns];
FillArray(matrix);
PrintArray(matrix);