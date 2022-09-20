
class HelloWorld
{
    static int CheckNumbers(int a, int b, int c)
    {
    int d=0;
       if (a%2==0 && b%2==0 && c%2==0)
       {
        d = 0;
       }
       else {
        d = 1;
       }
        return d;
    }
        

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
       Console.WriteLine(CheckNumbers(a,b,c));
    }
}
