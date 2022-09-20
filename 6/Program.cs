class HelloWorld
{
    static int checkPoint(int x, int y)
    {
        int a=0;
        if (x>1 && x<4 && y>2 && y<7)
        {
            a = 1;
        }
        else
        {
            a=0;
        }
        return a;
    }
        

    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
       Console.WriteLine(checkPoint(x,y));
    }
}