//  Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


int [] CreatedArray (int length, int min, int max){
    int [] answer = new int [ length];
    Random rnd = new Random();
    for (int i=0; i < answer.Length; i++)
    {
        answer [i] = rnd.Next (min, max+1);
    }
    return answer;
} 
int SumNegativElements (int []array)
{
    int sum = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array [i] <0)
        {
            sum += array [i];
        }
    }
    return sum;
}
int SumPositivElements (int [] array)
{
    int sum = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array [i] >0)
        {
            sum += array [i];
        }
    }
    return sum;
}
void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
}

int [] array = CreatedArray(12, -9, 9);
PrintArray (array);
int sumPositiv = SumPositivElements (array);
int SumNegativ = SumNegativElements (array);
System.Console.WriteLine($"{sumPositiv} f jnh {SumNegativ}");