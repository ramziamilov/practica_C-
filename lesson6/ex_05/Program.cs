// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] answer = new int[array.Length];
    int i = 0;
    while (i < array.Length)
    {
        answer[i] = array[i];
        i++;
    }
    return answer;
}


void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(" {0, 4}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("]");
    System.Console.WriteLine();
}

int[] array = { 1, 2, 3, 4, 5 };

int[] array2 = array;
array[0] = 10;
System.Console.WriteLine("массив аррэй");
PrintArray(array);
System.Console.WriteLine("массив аррэй2");
PrintArray(array2);


int[] array3 = CopyArray(array);

array[0] = 11;
System.Console.WriteLine("массив аррэй3");
PrintArray(array3);


System.Console.WriteLine("массив аррэй");

PrintArray(array);

System.Console.WriteLine("массив аррэй2");

PrintArray(array2);