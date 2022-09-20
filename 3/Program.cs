
class HelloWorld
{
    static double CountX(int x)
    {
        int x2 = x*x;
        double res = (3 * Math.Pow(x,3) + 18 * Math.Pow(x,2))*x + 12*Math.Pow(x,2) - 5;
        return res;
    }
        

    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
       Console.WriteLine(CountX(x));
    }
}