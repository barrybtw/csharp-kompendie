namespace Afsnit15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Bog sherlockHolmes = new Bog();
        sherlockHolmes.PrintInfo();
    }

    class Bog
    {
        public void PrintInfo()
        {
            Console.WriteLine("Jeg er en bog");
        }
    }

}