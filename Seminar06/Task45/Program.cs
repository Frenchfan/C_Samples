// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] CopyArray(int[] myArray)
{
int[] result = new int[myArray.Length];

    for (int i = 0; i < myArray.Length; i++)
    {
        result[i] = myArray[i];
    }
return result;
}

int[] myArray = {1,2, 6, 4, 1};
int[] newArray = CopyArray(myArray);
Console.WriteLine($"Копия массива {String.Join(" ", newArray)}");