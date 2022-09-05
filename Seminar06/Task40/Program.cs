// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
bool isExist(int[] myArray) 
 {
    bool result = false;
    return myArray[0] < myArray[1] + myArray[2] 
    && myArray[1] < myArray[0] + myArray[2] && myArray[2] < myArray[0] + myArray[1];  
 }

int[] triangle = new int[3];
Console.WriteLine("Введите длину первой стороны");
triangle[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
triangle[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
triangle[2] = int.Parse(Console.ReadLine());
Console.WriteLine($"Ответ на вопрос, может ли существовать треугольник: {isExist(triangle)}");