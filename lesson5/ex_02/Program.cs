// Задача 1: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
}

int[] CreatedArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}


int[] ReversArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    for (i = 0; i < count; i++)
    {
     array[i] = -array[i];
    }               
    return array;
}

 int [] array1 = CreatedArray (10, -69, 125);
 PrintArray (array1);
 PrintArray (ReversArray(array1));  
