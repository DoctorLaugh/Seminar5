int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
int FindNum(int[] array)
{
    int num = 0;
    foreach (int i in array)
    {
        if (i > 9 && i < 100)
            num = num + 1;
    }
    return num;
}
Console.Clear();
Console.WriteLine("Введите размер массива");
int Size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int MaxValue = int.Parse(Console.ReadLine());
int[] Array = RandomArray(Size, MinValue, MaxValue);
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
int Num = FindNum(Array);
Console.WriteLine($"Количество чисел от 10 до 99 в массиве - {Num}");