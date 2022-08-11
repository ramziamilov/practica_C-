// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}

int x = Prompt("Введите X >");
int y = Prompt("Введите Y>");
if (x == 0 || y == 0)
{
    System.Console.WriteLine("невозможно вычислить четверть, точка на оси");
}

int quarter = 0;

if (x > 0 && y > 0)
{
    quarter = 1;
}
if (x < 0 && y > 0)
{
    quarter = 2;
}

if (x < 0 && y < 0)
{
    quarter = 3;
}

if (x > 0 && y < 0)
{
    quarter = 4;
}
