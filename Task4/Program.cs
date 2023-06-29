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
int[] NewArray(int[] array)
{
    int[] newarray = new int[(array.Length / 2 + array.Length % 2)];
    for (int i = 0; i < (array.Length / 2 + array.Length % 2); i++)
    {
        newarray[i] = array[i] * array[(array.Length - (i+1))];
        if(i == array.Length - (i+1)) newarray[i] = Convert.ToInt32(Math.Sqrt(newarray[i]));
    }
    return newarray;
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
int[] newArray = NewArray(Array);
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write($"{newArray[i]} ");
}