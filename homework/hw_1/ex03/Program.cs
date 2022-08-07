//четное или нечетное число?
System.Console.Write("Введите любое число: ");
string value = Console.ReadLine();
int number = int.Parse (value);

if (number%2 == 0)
{
    System.Console.WriteLine($" Число {number} - четное");
}
else
{
    System.Console.WriteLine($" Число {number} - нечетное");
}
