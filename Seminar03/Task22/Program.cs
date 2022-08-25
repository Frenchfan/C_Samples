Console.WriteLine("Введите число более или равное 1: ");
int a = int.Parse(Console.ReadLine());
if (a < 1) 
{
    Console.WriteLine("Число должно быть равно единице или быть больше");
}   
else  
{
    int counter = 1;
    while (counter <= a)
        {
    Console.Write($"{counter * counter} ");
    counter++;
        }
}