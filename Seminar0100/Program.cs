Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Результат = {0}", sqr);// 0 - Индекс переменной, указанной после текста через запятую 
Console.WriteLine($"Результат = {sqr}"); // предпочтительный вариант.$ - показывает, что есть переменная

int result = Convert.ToInt32(Math.Pow(number, 2));// самый правильный вариант, поскольку Pow выдает результат типа double
Console.WriteLine($"Результат = {result}");
