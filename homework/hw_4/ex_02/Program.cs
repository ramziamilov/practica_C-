// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11; 82 -> 10; 9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int Sum(int number)
{
    int result = 0;

    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
if (number >= 0)
{
    System.Console.WriteLine(Sum(number));
}
else
{
    System.Console.WriteLine("некорректный ввод");
}