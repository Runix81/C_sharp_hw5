// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] Array(string msg)
{
    Console.Write($"{msg} -> ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void SubOfMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    System.Console.Write($"{array[0]} ");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
        if (array[i] >= max) max = array[i];
        if (array[i] <= min) min = array[i];
    }
    System.Console.WriteLine("");
    double result = max - min;
    System.Console.WriteLine($"Разница между максимальным значением массива {max} и минимальным значением {min} равна {result}.");
}

SubOfMaxMin(Array("Введите размер массива"));