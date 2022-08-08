int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}


int num1 = Prompt("Введите первое число:"); // вводим значение
if (num1 % 7 == 0 && num1 % 23 == 0)
{
    System.Console.WriteLine("da");
}
else
{
    System.Console.WriteLine("HeT");
}