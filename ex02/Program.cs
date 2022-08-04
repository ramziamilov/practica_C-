int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}

int numberOne = Prompt("Введите первое число:");
int numberTwo = Prompt ("Введите второе число:");

int resault = numberOne * numberOne;
if (resault == numberTwo)
{
    System.Console.WriteLine($"Число {numberOne} является квадратом числа {numberTwo}");
}

else 
{
    System.Console.WriteLine($"Число {numberOne} не является квадратом числа {numberTwo}");
}