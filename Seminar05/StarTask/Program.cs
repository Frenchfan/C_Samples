//Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сортировку.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] SortDown(int[] myArray) 
{
    int temp;
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i + 1; j < myArray.Length; j++)
            {
                if (myArray[i] < myArray[j])
                {
                    temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                }                   
            }            
        }
    return myArray;
}

int[] myArray = GetArray(6, 1, 99);
Console.WriteLine($"Исходный массив {String.Join(", ", myArray)}");
Console.WriteLine($"Отсортированный (невозрастающий) массив: {String.Join(", ", SortDown(myArray))}");

