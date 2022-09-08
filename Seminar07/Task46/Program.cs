//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
int[,] GetArray(int line, int column)
{
    int[,] res = new int[line, column];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i,j] = new Random().Next(1, 100);  
            Console.Write($"{res[i, j]} ");          
        }
        Console.WriteLine();
    }
    return res;
}
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(rows, columns);