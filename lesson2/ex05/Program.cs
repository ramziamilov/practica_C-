//Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа


int number = new Random().Next(10, 10000);
System.Console.WriteLine(number);

int max = 0;

while (number > 0)
{
    int a = number % 10;
    if (max < a)
    {
        max = a;
    }
    number=number/10;
    
}
System.Console.WriteLine(max);