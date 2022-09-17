//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int line, int column)
{
    int[,] res = new int[line, column];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = new Random().Next(1, 10);
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
int[,] MatrixMultiply(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Исходный массив 1: ");
int[,] firstMatrix = GetArray(rows, columns);
PrintArray(firstMatrix);
Console.WriteLine("Исходный массив 2: ");
int[,] secondMatrix = GetArray(rows, columns);
PrintArray(secondMatrix);
int[,] multipliedMatrix = MatrixMultiply(firstMatrix, secondMatrix);
Console.WriteLine("Произведение матриц: ");
PrintArray(multipliedMatrix);
