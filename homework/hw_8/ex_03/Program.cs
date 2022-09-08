// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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



int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }
    return matrix3;
}



int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] matrixOne = new int[rows, columns];
FillArray(matrixOne);
PrintArray(matrixOne);
System.Console.WriteLine();
int[,] matrixTwo = new int[rows, columns];
FillArray(matrixTwo);
PrintArray(matrixTwo);
System.Console.WriteLine();
int[,] resultMatrix = MultiplicationMatrix(matrixOne, matrixTwo);
PrintArray(resultMatrix);