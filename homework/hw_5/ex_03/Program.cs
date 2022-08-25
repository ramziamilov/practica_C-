// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76

void PrintArray(double[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(" {0, 4}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { System.Console.Write("; "); }
    }

    System.Console.Write("]");
    System.Console.WriteLine();
}

double[] ArrayFill(int size)
{
    int i = 0;
    double[] array = new double[size];

    while (i < size)
    {
        if (new Random().Next(0, 2) == 0) // или целое или дробное

        {
            array[i] = Math.Round(new Random().NextDouble() * new Random().Next(0, 100), 2);
        }
        else
        {
            array[i] = new Random().Next(0, 100);
        }

        i++;
    }
    return array;
}

double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double result = Math.Round( max - min, 2);
    return result;
}


double[] array = ArrayFill(6);
PrintArray(array);
double result = DifferenceMaxMin(array);
System.Console.WriteLine(result);
