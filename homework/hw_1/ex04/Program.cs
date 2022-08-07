//принмаем число Н и выводим интрвал четных чисел от 1  до Н


System.Console.Write("Введите любое число: ");
string value = Console.ReadLine();
int number = int.Parse(value);

int count = 1;

while (count < number)
{
    if (count % 2 == 0)
    {
        System.Console.Write($" {count} ");
    }
    count++;
}