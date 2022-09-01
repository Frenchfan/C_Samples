// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble()*1000;
    }
    return res;
}

double MinMaxDifference(double[] myArray) 
{
    double result = 0;
    double min = myArray[0], max = myArray[0];
    for (int i = 1; i < myArray.Length; i ++) 
    {
        if (myArray[i] > max) max = myArray[i];
        else if (myArray[i] < min) min = myArray[i];
    }
    return max - min;
}

double[] myArray = GetArray(6);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет: {MinMaxDifference(myArray)}");
Console.WriteLine($"Исходный массив {String.Join(", ", myArray)}");
