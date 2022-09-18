/* Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
Пример правильной скобочной последовательности: (), ()[]{}
Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная последовательность была введена */
bool CheckBraces(string data)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in data)
    {
        switch (c)
        {
            case '(':
            case '[':
            case '{':
                stack.Push(c);
                break;
            case ')':
            case ']':
            case '}':
                if (!CheckMatch(stack.Pop(), c))
                {
                    return false;
                }
                break;
        }
    }
    return true;
}
bool CheckMatch(char a, char b)
{
    return a == '(' && b == ')' ||
           a == '[' && b == ']' ||
           a == '{' && b == '}';
}

Console.Write("Введите скобочную последовательность: ");
string inputLine = Console.ReadLine();
inputLine = CheckBraces(inputLine) ? "корректная" : "некорректная";
Console.WriteLine($"Введенная скобочная последовательность {inputLine}");