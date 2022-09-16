// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int FunctionAkkerman(int numberOne, int numberTwo)
{

    if (numberOne == 0)
    {
        return numberTwo + 1;
    }
    else
    {

        if (numberOne != 0 && numberTwo == 0)
        {
            return FunctionAkkerman(numberOne - 1, 1);
        }
        else
        {
            return FunctionAkkerman(numberOne - 1, FunctionAkkerman(numberOne, numberTwo - 1));
        }
    }
}

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
int result = FunctionAkkerman(m, n);
Console.WriteLine(result);
