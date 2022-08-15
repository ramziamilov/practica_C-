//принимает число Н и выводит сумму чисел до Н

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int SumNumbers (int number)
{
    int answer = 0;
    for (int i=0; i <= number; i++)
    {
        answer = answer + i;
    }
    return answer;
}

int number = Prompt ("Введите число для суммы: ");
System.Console.WriteLine( $"Cумма чисел от 1 до {number} состовляет {SumNumbers(number)}");