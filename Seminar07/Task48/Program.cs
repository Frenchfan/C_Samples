//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5
int[,] GetArray(int line, int column)
{
    int[,] res = new int[line, column];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i,j] = i + j;  
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
