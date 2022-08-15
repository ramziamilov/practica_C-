// Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

int[] GenerateArray(int Length) // создание массива
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
}

int [] arr = GenerateArray (8);
PrintArray(arr);