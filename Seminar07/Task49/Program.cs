//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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
int[,] FindEvenReplace(int[,] res)
{
    for (int i = 0; i < res.GetLength(0); i += 2)
    {
        for (int j = 0; j < res.GetLength(1); j += 2)
        {
            res[i, j] *= res[i, j];
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(rows, columns);
Console.WriteLine("Исходный массив: ");
PrintArray(myArray);
myArray = FindEvenReplace(myArray);
Console.WriteLine();
Console.WriteLine("Массив с заменами: ");
PrintArray(myArray);