// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
 int[] ReverseArray(int[] myArray) 
 {
    int[] result = new int[myArray.Length];
    int counter = 0;
    for (int i = myArray.Length - 1; i >=0; i--) 
    {
        result[counter] = myArray[i];
        counter++;
    }
    return result;
 }

int[] myArray = GetArray(5, 1, 100);
Console.WriteLine($"Перевернутый массив {String.Join(", ", ReverseArray(myArray))}");
Console.WriteLine($"Исходный массив {String.Join(", ", myArray)}");