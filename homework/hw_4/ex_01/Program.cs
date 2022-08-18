// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵);  2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int DeegreOfNumber(int numOne, int numTwo)
{
    if (numTwo > 0)
    {
        int value= 1;
        for (int i = 0; i < numTwo; i++)
        {
           value = numOne*value;
        }
         return value;
    }
    else
    {
        Console.WriteLine("некорректный ввод");
    return 0;
    }


   
}

int numOne = Prompt("Введите число: ");
int numTwo = Prompt("Введите второе число: ");
int result = DeegreOfNumber(numOne, numTwo);
Console.WriteLine(result);
