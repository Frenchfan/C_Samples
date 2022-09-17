// Задача 61: Вывести первые N строк треугольника Паскаля. 
//Сделать вывод в виде равнобедренного треугольника
void PascalTriangle(int rows)
{
    int width = 2 * rows - 1;
    int halfshift = (width - 1) / 2;
    int[][] triangle = new int[rows][];
    triangle[0] = new int[1] { 1 };
    for (int i = 1; i < triangle.GetLength(0); i++)
    {
        triangle[i] = new int[i + 1];
        triangle[i][0] = 1;
        int myLength = triangle[i].Length;
        triangle[i][myLength - 1] = 1;
        for (int j = 1; j < myLength - 1; j++)
        {
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
        }
    }
    int additionalShift = 1;
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j < halfshift; j++)
        {
            Console.Write(" ");
        }
        Console.Write($"{String.Join(" ", triangle[i])}");
        Console.WriteLine();
        halfshift--;
    }
}

Console.WriteLine("Введите кол-во строк треугольник Паскаля (число должно быть не менее 3):");
int rows = int.Parse(Console.ReadLine());
PascalTriangle(rows);