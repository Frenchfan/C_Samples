//Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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
int FindSumDiagonal(int[,] res)
{
    int sum = 0;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        sum +=res[i, i];
    }
    return sum;
}
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(rows, columns);
Console.WriteLine($"Сумма элементов на главной диагонали: {FindSumDiagonal(myArray)}");
