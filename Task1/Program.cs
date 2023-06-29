int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}
int[] PosNegViseVersa(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i] * -1;
    }
    return result;
}
Console.Clear();
int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
int[] res = PosNegViseVersa(array);
Console.WriteLine(String.Join(", ", res));