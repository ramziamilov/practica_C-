//Напишите рограмму, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.п

int number = new Random().Next(10, 99);
System.Console.WriteLine(number);

int numberOne = number % 10;
int numbertwo = number / 10;

if (numberOne> numbertwo)
{
    System.Console.WriteLine(numberOne);
}
else 
{
    System.Console.WriteLine(numbertwo);
}