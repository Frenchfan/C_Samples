int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);        
    }
    return res;
}
int[] ProductionArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 != 0) size++;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) result[size - 1] = array[array.Length / 2];
    return result;
    
}


int[] myArray = GetArray(5, -100, 100);

int[] resultArray = new int[myArray.Length];
resultArray = ProductionArray(myArray);
foreach (int i in resultArray) {
    Console.WriteLine(i);
}
