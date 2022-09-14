//Задача 55: Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.
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
int[,] SwapLinesColumns(int[,] res)
{
    if (res.GetLength(0) == res.GetLength(1))
    {
        for (int i = 0; i < res.GetLength(0)-1; i++)
        {
            for(int j= i+1; j<res.GetLength(0); j++)
            {
                int temp = res[i, j];
                res[i, j] = res[j,i];
                res[j,i] = temp;
            }
            
        }
        return res;      
    }
    else
    {
        Console.WriteLine("Замена невозможна");
        return res;
    }
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
myArray = SwapLinesColumns(myArray);
Console.WriteLine("Новый массив: ");
PrintArray(myArray);