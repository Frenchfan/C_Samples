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
int[,] SortDown(int[,] myArray)
{
    for (int k = 0; k < myArray.GetLength(0); k++)
    {
        for (int i = 0; i < myArray.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < myArray.GetLength(1); j++)
            {
                if (myArray[k, i] < myArray[k, j])
                {
                    int temp = myArray[k, i];
                    myArray[k, i] = myArray[k, j];
                    myArray[k, j] = temp;
                }
            }
        }
    }
    return myArray;
}
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Исходный массив: ");
int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);
SortDown(myArray);
Console.WriteLine("Отсортированный по убыванию массив: ");
PrintArray(myArray);