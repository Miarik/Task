
class HelloWorld
{
    static int CheckTime(int a, int b)
    {
        int c = 0;
        if (a <= 23 && b <= 59)
        {
            c = 1;
        }
        else
        {
            c = 0;
        }
        return c;
    }

    static void Main()
    {
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine(CheckTime(c,d));
    }
}
