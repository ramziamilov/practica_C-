//программа принимает на вход число N и выводит все числа от -N до N

System.Console.Write("введите число:");
string value = Console.ReadLine ();
int number = int.Parse (value);

int resault = - (number + 1);

while (resault != number)
{
    resault++;
    System.Console.WriteLine(resault);  
}
