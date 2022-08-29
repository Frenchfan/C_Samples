//Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами 
//из [a, b) и выводит их на экран.

int[] RandomNumsExt(int arraySize, int bottom, int top)
{    
    int[] myArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        myArray[i]= new Random().Next(bottom,top);
        Console.Write($"{myArray[i]} ");
    }
    return myArray;
}
Console.WriteLine("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
RandomNumsExt(n, a, b);

//Console.WriteLine($"{String.Join(" ",RandomNumsExt())}"); - вновь голосую за решение без доп. перебора массива
