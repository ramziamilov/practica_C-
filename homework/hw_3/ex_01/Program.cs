//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом


int[] arrayNew(string massage) // функция перевода числа в массив из цифр
{
    System.Console.Write(massage);
    string input = System.Console.ReadLine().ToString();
    int[] array = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        array[i] = int.Parse(input[i].ToString());

    }
    return array;
}

int [] chekPolindrom (int [] array)
{
if (array[0] > 0 && array.Length == 5)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        System.Console.WriteLine( "Палиндром");
    }
    else
    {
        System.Console.WriteLine("Не палиндром");
    } 
}
else {
    System.Console.WriteLine("некоректные данные");
}
return array;
}

int[] number = arrayNew("Введите пятизначное число: ");
chekPolindrom (number);





