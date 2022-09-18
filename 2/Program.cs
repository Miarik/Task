class HelloWorld
{
    static char[] SwapNumbers(int num)
    {
        char[]arr = num.ToString().ToCharArray();
        // char temp = arr[arr.Length-1];
        // arr[arr.Length-1] = arr[arr.Length-2];
        // arr[arr.Length-2] = arr[0];
        // arr[0] = temp;
        // return arr;
        for (int i = 0; i < arr.Length; i++)
        {
            char temp = arr[arr.Length-1];
            arr[i] = arr[i+1];
            arr[0] = temp;
            return arr;
        }
    }

    static void PrintArray(char[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i] }");
        }
    }
        

    static void Main()
    {   
        Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine());
        PrintArray(SwapNumbers(num));
    }
}