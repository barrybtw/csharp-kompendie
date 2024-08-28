namespace Afsnit7;

class Program
{
    static void Main(string[] args)
    {
        int x = 101;
        int y = 545;
        int z = 1234;

        int result = x % z - y + z / y;
        
        int result2 = x % z - y + z / y * 5;

        Console.WriteLine($"{result}, {result2}");

    }
}