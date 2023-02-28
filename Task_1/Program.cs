// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




int[] Array(string msg)
{
    Console.Write($"{msg} -> ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void EvenQuantity(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    System.Console.WriteLine("");
    System.Console.WriteLine($"В текущем массиве {counter} четных чисел.");

}
EvenQuantity(Array("Введите размер массива"));
