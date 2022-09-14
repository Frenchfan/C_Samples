// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива.

int[,] GetArray(int line, int column)
{
    int[,] res = new int[line, column];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = new Random().Next(0, 10);
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

int[] FindMinimum(int[,] array, int[] minArray)
{
    int minimumNumber = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minimumNumber > array[i, j]) ;
            minArray[0] = array[i, j];
            minArray[0] = i;
            minArray[1] = j;
        }
    }
    return minArray;
}

int[,] ChangeArray(int[,] array, int[] deleteArray)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0, l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != deleteArray[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != deleteArray[1])
                {
                    result[l, k] = array[i, j];
                    k++;
                }            
            }
            k = 0;
            l++;
        }
    }
    return result;
}

int[] SortDown(int[] myArray)
{
    for (int i = 0; i < myArray.Length - 1; i++)
    {
        for (int j = i + 1; j < myArray.Length; j++)
        {
            if (myArray[i] < myArray[j])
            {
                int temp = myArray[i];
                myArray[i] = myArray[j];
                myArray[j] = temp;
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
int[] minimumPositions = new int[2];
minimumPositions = FindMinimum(myArray, minimumPositions);
int[,] resultArray = ChangeArray(myArray, minimumPositions);
Console.WriteLine("Сокращенный массив: ");
PrintArray(resultArray);