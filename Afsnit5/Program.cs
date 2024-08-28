namespace Afsnit5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string x = "Hej med dig. Jeg er en smart variabel type!";
        Console.WriteLine(x);

        Console.WriteLine("I dag har vi den 20 november");
        
        Part2();
    }

    static private void Part2()
    {
        double penge = 200.50;
        string statement = "Jeg har ";
        string end = " kr. i banken";

        Console.WriteLine($"{statement}{penge}{end}");
    }
}