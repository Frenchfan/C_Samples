int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        //Console.WriteLine($"{res[i]}");
    }
    return res;
}

int[] minusPlus(int[] array) 
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++) {
        result[i] = -array[i];
    }
    return result;
}

int[] myArray = GetArray(4, -100, 100);
foreach(int i in myArray) 
{
    Console.WriteLine(i);
}
Console.WriteLine(String.Join(" ", minusPlus(myArray)));
