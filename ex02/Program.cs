int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}

int numberOne = Prompt("Введите первое число:");
int numberTwo = Prompt("Введите второе число:");

int resault = numberOne * numberOne;
if (resault == numberTwo)
{
    System.Console.WriteLine($"Число {numberTwo} является квадратом числа {numberOne}");
}

else
{
    System.Console.WriteLine($"Число {numberTwo} не является квадратом числа {numberOne}");
}