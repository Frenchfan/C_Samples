//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] GetArray(int line, int column)
{
    double[,] res = new double[line, column];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
    return res;
}
void PrintArray(double[,] array)
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
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
double[,] myArray = GetArray(rows, columns);
Console.WriteLine($"Двумерный массив {rows} x {columns}, заполненный случайными вещественными числами (округление до 2-х знаков): ");
PrintArray(myArray);