﻿/*
Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void SetN(int num)
{
 int i=1;   
    while(i<=num)

    {
        
        System.Console.Write(i*i+" ");
        i++;
        
    }


}


SetN(Prompt("Введите число : "));


int[] arrayFill(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(0, 101);
        i++;
    }
    return array;
}


void printArray(int[] array) // вывод массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }

}

int Max(int[] array) // вывод максимального числа изх массива
{
    int maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum) { maxNum = array[i]; }
    }
    return maxNum;
}

double Mid(int[] array) // вывод среднего арифмитического массива
{
    double sumArray = 0;
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sumArray += array[i];
    }
    result = ((double)sumArray) / array.Length;
    return result;
}

int[] result = arrayFill(5);
printArray(result);


System.Console.Write($"Max={Max(result)} ");
System.Console.Write($"Mid={Mid(result)} ");
