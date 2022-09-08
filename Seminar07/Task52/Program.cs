//Задача 52: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


int[,] GetArray(int line, int column)
{
    int[,] result = new int[line, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
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
double[] FindAverageColumns(int[,] res)
{
    double[] average = new double[res.GetLength(1)];
    int counter = 0;
    for (int i = 0; i < res.GetLength(1); i++)
    {
        for (int j = 0; j < res.GetLength(0); j++)
        {
            average[counter] += res[j, i];
        }
        average[counter] = Math.Round(average[counter] / res.GetLength(0), 1);
        counter++;
    }
    return average;
}
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(rows, columns);
Console.WriteLine("Исходный массив: ");
PrintArray(myArray);
double[] average = FindAverageColumns(myArray);
Console.WriteLine($"Среднее арифметическое каждого столбца (округление до 1 цифры после запятой): {String.Join(";", average)}");