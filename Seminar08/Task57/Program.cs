// Задача 57: Составить частотный словарь элементов 
//двумерного массива. Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных.
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
int[] TwoDimensionstoOne(int[,] res)
{
    int[] temp = new int[res.GetLength(0) * res.GetLength(1)];
    int k = 0;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            temp[k] = res[i, j];
            k++;
        }
    }
    return temp;
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

void CountValues(int[] inputArray) 
{
    int counter = 1; 
    for (int i = 0; i < inputArray.Length-1; i++)
    {
        if (inputArray[i] == inputArray[i+1] )
        {
            counter++;
        }
        else
        {
            Console.WriteLine($"Value {inputArray[i]} {counter} times in array");
            counter = 1;
        }
    }
    Console.WriteLine($"Value {inputArray[inputArray.Length-1]} {counter} times in array");
}

Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Исходный массив: ");
int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);
Console.WriteLine("Частотный словарь: ");
int[] newArray = TwoDimensionstoOne(myArray);
SortDown(newArray);
CountValues(newArray);
