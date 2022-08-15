// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

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

int [] numberCount (int [] array) {

System.Console.WriteLine(array.Length);
return array;
}


int[] number = arrayNew("Введите число: ");
numberCount (number);
