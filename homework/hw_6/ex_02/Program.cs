// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}

void FindCrossing(double k1, double b1, double k2, double b2)
{

    if (k1 * b2 - k2 * b1 == 0)
    {
        System.Console.WriteLine("прямые параллельны - решения нет!");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * (b2 - b1) / (k1 - k2) + b2;
        System.Console.WriteLine($"координата точки пересения прямых: ({x:f1}; {y:f1})");
    }
}

double k1 = Prompt("Введите К1: ");
double b1 = Prompt("Введите b1: ");
double k2 = Prompt("Введите К2: ");
double b2 = Prompt("Введите b2: ");

FindCrossing(k1, b1, k2, b2);