
class HelloWorld
{
    static void SwapNumbers(ref int a, ref int b)

    {
        int temp = 0;
        if (a < b)
        {
            temp = a;
            a = b;
            b = temp;
        }
    }


    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(SwapNumbers(ref a, ref b));
    }
}
