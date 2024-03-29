﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
 int CountEven(int[] myAray) 
 {
    int result = 0;
    foreach (int el in myAray) 
    {
        if (el %2 == 0) result++;
    }
    return result;
 }

int[] myArray = GetArray(46, 100, 999);
Console.WriteLine($"Количество четных чисел в массиве составляет: {CountEven(myArray)}");
//Console.WriteLine($"Исходный массив {String.Join(", ", myArray)}");
