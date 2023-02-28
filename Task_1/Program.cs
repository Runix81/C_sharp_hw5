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
void PrintArray()
{
    int[] array = Array("Введите размер массива");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
int EvenQuantity(int[] array)
{
    
}
PrintArray();
