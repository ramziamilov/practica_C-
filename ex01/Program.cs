//программа которая на входе принимает число и выводит его квадрат

// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
}

int value = Prompt("Введите число:"); // вводим значение
int resault = value * value; // вычисляем квадрат
System.Console.WriteLine($"Квадрат числа {value} равен {resault}"); // вывод результата