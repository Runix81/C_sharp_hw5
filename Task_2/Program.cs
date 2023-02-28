// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] Array(string msg)
{
    Console.Write($"{msg} -> ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}

void OddElementsSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
        if (i % 2 != 0) sum = sum + array[i];


    }
    System.Console.WriteLine("");
    System.Console.WriteLine($"Сумма чисел стоящих на нечетных позициях равна {sum}.");

}

OddElementsSum(Array("Введите размер массива"));

