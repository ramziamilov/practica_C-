System.Console.Write("Введите первое число: ");
string valueOne = Console.ReadLine();
System.Console.Write("Введите второе число: ");
string valueTwo = Console.ReadLine();
System.Console.Write("Введите третье число: ");
string valueThree = Console.ReadLine();

int numberOne = int.Parse(valueOne);
int numberTwo = int.Parse(valueTwo);
int numberThree = int.Parse(valueThree);

if (numberOne > numberTwo)
{
    if (numberTwo > numberThree)
    {
        System.Console.WriteLine($"Максимальное число = {numberOne}");
    }
}
else
{
    if (numberTwo > numberThree)
    {
        System.Console.WriteLine($"Максимальное число = {numberTwo}");
    }

    else
    {
        System.Console.WriteLine($"Максимальное число = {numberThree}");
    }
}