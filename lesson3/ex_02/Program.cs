// программа получает а вход координаты точек и находит расстояние мужду ними

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}

int x1 = Prompt("Введите X1: ");
int x2 = Prompt("Введите X2: ");
int y1 = Prompt("Введите Y1: ");
int y2 = Prompt("Введите Y2: ");

double result = Math.Sqrt ((x2-x1)*(x2-x1)+ (y2-y1)*(y2-y1));
System.Console.WriteLine(result); 