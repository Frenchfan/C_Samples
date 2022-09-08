//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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
int[,] FindEvenReplace(int[,] res)
{
    Console.WriteLine("Массив с заменами: ");
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) res[i,j] *= res[i,j];  
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
myArray = FindEvenReplace(myArray);
