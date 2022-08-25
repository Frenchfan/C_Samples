Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int stop = (a % 2 == 0) ? a : (a - 1);
int counter = 2;
while (counter <= stop) 
{
    Console.Write($"{counter} ");
    counter += 2;
}
