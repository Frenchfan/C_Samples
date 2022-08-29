int[] RandomNums()
{    
    int[] myArray = new int[8];
    for (int i = 0; i <= 7; i++)
    {
        myArray[i]= new Random().Next(0,2);
        //Console.WriteLine($"{myArray[i]}");
    }
    return myArray;
}

Console.WriteLine($"{String.Join(" ",RandomNums())}");
