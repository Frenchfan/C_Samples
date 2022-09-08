//Задача 50: Напишите программу, которая на вход принимает число 
//и возвращает позицию этого элемента в двумерном массиве 
//или же указание, что такого элемента нет.

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
void FindDigit(int[,] res, int digit)
{
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            if (res[i, j] == digit)
            {
                Console.Write($"Число {digit} впервые встречается на позиции [{i}, {j}] ");
                return;
            };
        }
    }
    Console.Write($"Числа {digit} в массиве нет ");
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
int[,] myArray = GetArray(rows, columns);
Console.WriteLine("Исходный массив: ");
PrintArray(myArray);
Console.WriteLine("Введите число для поиска в массиве: ");
int digit = int.Parse(Console.ReadLine());
FindDigit(myArray, digit);