int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}


int num1 = Prompt("Введите первое число:"); // вводим значение
int num2 = Prompt ("Введите второе число:");
int ost;
ost = num1%num2;
if (ost == 0)
{
System.Console.WriteLine("кратно");
}
else 
{
    System.Console.WriteLine($"не кратно, остаток {ost}");
}
