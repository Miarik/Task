﻿class HelloWorld
{
    static char[] SwapNumbers(int num)
    {
        char[]arr = num.ToString().ToCharArray();
        // char temp = arr[arr.Length-1];
        // arr[arr.Length-1] = arr[arr.Length-2];
        // arr[arr.Length-2] = arr[0];
        // arr[0] = temp;
        // return arr;
        char temp = arr[arr.Length-1];
        arr[0] = temp;
        for (int i = 0; i < arr.Length-1; i++)
        {
            arr[arr.Length - 1 - i] = arr[arr.Length - 2 - i];
        }
        return arr;
    }

    static void PrintArray (char[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
        
        

    static void Main()
    {   
        Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine());
        PrintArray(SwapNumbers(num));
    }
}