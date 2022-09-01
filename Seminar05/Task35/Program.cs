int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);        
    }
    return res;
}

int findIntervalinArray(int min, int max, int[] array)
{
    int quantity = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) 
        {
            quantity++;
        };        
    }
    return quantity;
}

Console.WriteLine("Введите диапазон для поиска в массиве: минимум (включая)");

int minimum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон для поиска в массиве: минимум (включая)");
int maximum = int.Parse(Console.ReadLine());

int[] myArray = GetArray(123, -100, 100);
Console.WriteLine($"Найдено - {findIntervalinArray(minimum, maximum, myArray)} чисел / сла");

