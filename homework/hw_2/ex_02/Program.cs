//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int value = new Random().Next(100, 1000);
System.Console.WriteLine(value);

int three = value % 10;
int two = value / 10 % 10;
int one = value / 100 % 10;
System.Console.WriteLine($"{one}{three}");