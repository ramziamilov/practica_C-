//  Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. 
//И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение 
    string readValue = Console.ReadLine();// считывает с консоли строку
    int resault = int.Parse(readValue);// преобразует строку в целое число
    return resault; // возвращает результат
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
void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
}
int SecondMaxElement(int[] array)
{
    int maxElement = array[0];
    int secondmax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            secondmax = maxElement;
            maxElement = array[i];
        }
        else
        {
            if (array[i] > secondmax && array[i] != maxElement)
            {
                secondmax = array[i];
            }

        }
    }
    return secondmax;
}

int Length = Prompt("Введите количество элементов массива: ");
int min = Prompt("Введите нижнюю границу массива: ");
int max = Prompt("Введите верхнюю границу массива: ");
int[] array = CreatedArray(Length, min, max);
PrintArray(array);
System.Console.WriteLine();
Console.WriteLine($"второй максимум = {SecondMaxElement(array)}");
