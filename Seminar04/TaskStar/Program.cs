//Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки 
//и рисует ее в консоли звездочками.
void PineTree(int number)
{
    for (int i = 1; i <= number; i++)  
    {
        for (int j = number - i; j > 0; j--)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= i * 2 - 1; k++)
        {
                Console.Write("*");
        }
    Console.WriteLine();
    }    
}

Console.WriteLine("Введите высоту елочки: ");
int num = int.Parse(Console.ReadLine());
PineTree(num);
