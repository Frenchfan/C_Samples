// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int AddnotEven(int[] myArray) 
{
    int result = 0;
    for (int i = 1; i < myArray.Length; i += 2) 
    {
        result += myArray[i];
    }
    return result;
}

int[] myArray = GetArray(6, 1, 99);
Console.WriteLine($"Сумма элементов на нечетных позициях составит: {AddnotEven(myArray)}");
Console.WriteLine($"Исходный массив {String.Join(", ", myArray)}");


