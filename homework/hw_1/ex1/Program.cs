// программа: принимем на вход два числа и выдаем какео больше, а какое меньше


System.Console.Write("Введите первое число: ");
string valueOne = Console.ReadLine();
System.Console.Write("Введите второе число: ");
string valueTwo = Console.ReadLine();
int numberOne = int.Parse(valueOne); // преобразовали строки в числа
int numberTwo = int.Parse(valueTwo);

if (numberOne > numberTwo)
{
    System.Console.WriteLine($"max = {numberOne}, min = {numberTwo}");
}
else
{
  System.Console.WriteLine($"max = {numberTwo}, min = {numberOne}");
}