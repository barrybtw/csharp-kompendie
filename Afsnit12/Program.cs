namespace Afsnit12;

class Program
{
    static void Main(string[] args)
    {
        // 1 for
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);   
        }
        
        // 1 while
        int x = 0;
        while (x <= 100)
        {
            Console.WriteLine(x++);
        }
        
        // 2 for
        for (int i = 100; i >= 0; i--)
        {
            Console.WriteLine(i);   
        }
        
        // 2 while
        int y = 100;
        while (y >= 0)
        {
            Console.WriteLine(y--);
        }
        
        // 3
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(5*i);
        }
        
        // 4, do-while eksekverer koden først før konditionen evalueres første gang
        // while er modsat, den evaluerer først konditionen før den starter
    }
}