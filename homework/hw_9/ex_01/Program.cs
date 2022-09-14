// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
//все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void PrintEvenNumbers(int min, int max)
{
    if (min > max)
    {
        return;
    }
    PrintEvenNumbers(min, max-1);
    if (max % 2 == 0)
    {

        System.Console.WriteLine(max);
    }
}

int min = Prompt("Введите левую границу ряда чисел: ");
int max = Prompt("Введите правую границу ряда чисел: ");
PrintEvenNumbers(min, max);