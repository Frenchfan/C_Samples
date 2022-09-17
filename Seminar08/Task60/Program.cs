/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

// Мне кажется изящным вариант с Set, который не допускает появления повторяющихся элементов, 
//но, конечно, математики тут меньше, чем при переборе
/* int[,,] GetArray(int rows, int columns, int depth)
{
    int[,,] res = new int[rows, columns, depth];
    HashSet<int> mySet = new HashSet<int>();
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            for (int k = 0; k < res.GetLength(2); k++)
            {
                int temp = mySet.Count;
                while (temp == mySet.Count)
                {
                    res[i, j, k] = new Random().Next(10, 100);
                    mySet.Add(res[i, j, k]);
                }
            }
        }
    }
    return res;
} */
int[,,] GetArray(int rows, int columns, int depth)
{
    int[,,] res = new int[rows, columns, depth];
    int[] noDuplicates = new int[rows * columns * depth];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        int noDuplicatesCounter = 0;
        for (int j = 0; j < res.GetLength(1); j++)
        {
            for (int k = 0; k < res.GetLength(2); k++)
            {
                bool repeatFlag = false;
                do
                {
                    res[i, j, k] = new Random().Next(10, 100);
                    noDuplicates[noDuplicatesCounter] = res[i, j, k];
                    for (int l = 0; l < noDuplicatesCounter; l++)
                    {
                        if (noDuplicates[l] == noDuplicates[noDuplicatesCounter]) repeatFlag = true;
                    }
                    noDuplicatesCounter++;
                }
                while (repeatFlag);
            }
        }
    }
    return res;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],1}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine("Введите первую размерность массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую размерность массива: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью размерность массива: ");
int depth = int.Parse(Console.ReadLine());
Console.WriteLine("Вот такой массив был сгенерирован: ");
int[,,] myArray = GetArray(rows, columns, depth);
PrintArray(myArray);