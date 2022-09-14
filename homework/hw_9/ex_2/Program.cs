// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int SumNaturalNumbers(int min, int max)
{

    if (max < min || max < 0)
    {
        return 0;
    }
    return SumNaturalNumbers(min, max - 1) + max;

}

int min = Prompt("Введите левую границу ряда чисел: ");
int max = Prompt("Введите правую границу ряда чисел: ");
int sum = SumNaturalNumbers(min, max);
Console.WriteLine(sum);