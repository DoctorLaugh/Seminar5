int[] InputArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число для массива");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
bool TestNum(int[] array, int num)
{
    foreach (int el in array)
    {
        if (num == el) return true;
    }
    return false;
}
Console.Clear();
Console.WriteLine("Введите размер массива");
int Size = int.Parse(Console.ReadLine());
int[] Array = InputArray(Size);
Console.WriteLine(String.Join(", ", Array));
Console.Write("Введите число для проверки: ");
int Num = int.Parse(Console.ReadLine());
if(TestNum(Array, Num))
{
    Console.WriteLine("В массиве есть такое число");
}
else
{
    Console.WriteLine("В массиве нет такого числа");
}