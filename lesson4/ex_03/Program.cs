// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int number = Prompt("введите число ");
int mult = 1;
for (int i = 1; i <= number; i++)
{
    mult = mult * i;
}
System.Console.WriteLine(mult);