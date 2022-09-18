
class HelloWorld
{
    static int CountWeeks(int x)
    {
        x = x/7;
        return x;
    }
        

    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
       Console.WriteLine(CountWeeks(x));
    }
}