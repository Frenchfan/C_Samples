int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);        
    }
    return res;
}

bool findinArray(int myDigit, int[] array)
{
    bool res = false;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == myDigit) 
        {
            res = true;
        };        
    }
    return res;
}

Console.WriteLine("Введите число для поиска в массив: ");

int digit = int.Parse(Console.ReadLine());

int[] myArray = GetArray(4, -100, 100);
foreach(int i in myArray) 
{
    Console.Write($"{i}, ");
}
Console.WriteLine(findinArray(digit, myArray));