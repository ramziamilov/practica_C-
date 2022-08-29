// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}

void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
}

int[] InputArray(int Lenght)
{
    int[] array = new int[Lenght];
    int count = 0;

    for (int i = 0; i < Lenght; i++)
    {
        array[i] = Prompt("Введите число: ");

    }
    return array;
}

void CountNumbersMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
System.Console.WriteLine($" количество введенных чисел > 0 = {count}");
}


int size = Prompt("Введите количество чисел:");
int[] array = InputArray(size);
PrintArray(array);
CountNumbersMoreZero (array);



