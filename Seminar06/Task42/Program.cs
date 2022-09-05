// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
string toBinarySystem(int newdigit) 
{
    string result = "";
    while (newdigit > 0)
    {
        string tempdivision = (newdigit % 2).ToString();
        result = tempdivision + result;
        newdigit /= 2;
    }
    return result;
}


Console.WriteLine("Введите число");
int digit = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {digit} в двоичной системе {toBinarySystem(digit)}");

