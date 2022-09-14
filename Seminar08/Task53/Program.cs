//Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.
int[,] GetArray(int line, int column)
{
    int[,] res = new int[line, column];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = new Random().Next(1, 1000);
        }
    }
    return res;
}
int[,] SwapLines(int[,] res)
{
    for (int j = 0; j < res.GetLength(1); j++)
    {
        int swapper;
        swapper = res[0, j];
        res[0, j] = res[res.GetLength(0) - 1, j];
        res[res.GetLength(0) - 1, j] = swapper;
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
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Исходный массив: ");
int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);
myArray = SwapLines(myArray);
Console.WriteLine("Новый массив: ");
PrintArray(myArray);
