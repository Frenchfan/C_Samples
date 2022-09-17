/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
int[,] GetArray(int line, int column)
{
    int[,] res = new int[line, column];
    int lastRow = res.GetLength(0) - 1;
    int lastColumn = res.GetLength(1) - 1;
    int firstRow = 0, firstColumn = 0;
    int counter = 1;
    while (firstRow <= lastRow && firstColumn <= lastColumn)
    {
        for (int i = firstColumn; i <= lastColumn; i++)
        {
            res[firstRow, i] = counter++;
        }
        firstRow++;
        for (int i = firstRow; i <= lastRow; i++)
        {
            res[i, lastColumn] = counter++;
        }
        lastColumn--;

        if (firstRow <= lastRow && firstColumn <= lastColumn)
        {
            for (int i = lastColumn; i >= firstColumn; i--)
            {
                res[lastRow, i] = counter++;
            }
            lastRow--;     

            for (int i = lastRow; i >= firstRow; i--)
            {
                res[i, firstColumn] = counter++;
            }
            firstColumn++;
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

Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Заполненный спирально массив: ");
int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);