// Задача со звездочкой. Напишите программу, которая реализует обход 
//введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
int[][] GetArray(int line, int column)
{
    int[][] res = new int[line][];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new int[column];
        for (int j = 0; j < res[i].Length; j++)
        {
            res[i][j] = new Random().Next(10, 100);            
        }
        Console.WriteLine($"{String.Join(" ",res[i])}");
    }
    return res;
}
int[] AntiClockWise(int[][] myArray)
{
    int[] result = new int[myArray[0].Length * myArray.Length];
    int counter = 0;
    int i = 0;
    int bottomRowIndex = myArray.Length - 1;
    int topRowIndex = 0;
    int startColumnIndex = 0;
    int endColumnIndex = myArray[0].Length - 1;

  
        while (bottomRowIndex >= topRowIndex && startColumnIndex <= endColumnIndex) {         

            if (bottomRowIndex > topRowIndex) {
                for (i = startColumnIndex; i <= endColumnIndex; i++) {
                    result[counter] = myArray[bottomRowIndex] [i];
                    counter++;
                }
                bottomRowIndex--;
            }

            for (i = bottomRowIndex; i >= topRowIndex; i--) {
                result[counter] = myArray[i][endColumnIndex];
                counter++;
            }
            endColumnIndex--;


            for (i = endColumnIndex; i >= startColumnIndex; i--) {
                result[counter] = myArray[topRowIndex][i];
                counter++;
            }
            topRowIndex++;

            if (startColumnIndex < endColumnIndex) {
                for (i = topRowIndex; i <= bottomRowIndex; i++) {
                    result[counter] = myArray[i][startColumnIndex];
                    counter++;
                }
                startColumnIndex++;
            }
        }
    return result;
} 
Console.WriteLine("!!!Для простоты проверки пользователь вводит только размерность массива, числа (от 10 до 100 - для красоты отображения) будут сгенерированы случайным образом");
Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine());
int[][] myArray = GetArray(rows, columns);
Console.WriteLine("В результате обхода против часовой стрелки получился массив: ");
Console.WriteLine($"{String.Join(" ", AntiClockWise(myArray))}");