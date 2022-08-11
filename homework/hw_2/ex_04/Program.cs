// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}
int i = 0;
int[] array = new int[7];
array[i] = Prompt($"Введите номер дня: ");


if (array[i] == 6)
{
    System.Console.WriteLine("да");
}

else if (array[i] == 7)
{
    System.Console.WriteLine("да");

}
else
{
    System.Console.WriteLine("нет");

}