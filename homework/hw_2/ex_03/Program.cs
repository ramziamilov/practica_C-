//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int value = Prompt("ВВедите число: ");
if (value > 99)
{

    while (value > 1000)
    {
        value = value / 10;
    }
    int result = value % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}