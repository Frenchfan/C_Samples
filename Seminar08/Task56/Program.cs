//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int line, int column)
{
    int[,] res = new int[line, column];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = new Random().Next(1, 100);
        }
    }
    return res;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int FindMinSumLine(int[,] myArray)
{
    int minSumIndex = 0;
    int sum = 0, minSum = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            sum += myArray[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
            continue;
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumIndex = i;
        }
        sum = 0;
    }
    return minSumIndex + 1;
}
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Исходный массив: ");
int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);
int minLineSum = FindMinSumLine(myArray);
Console.WriteLine($"C наименьшей суммой элементов: {minLineSum} строка");