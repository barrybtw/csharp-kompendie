namespace Afsnit13b;

class Program
{
    static void Main(string[] args)
    {
        Part1();
        Part2("Nicolai");
        Part2("William");
        int x = Part3();
        Console.WriteLine(x);
        
        Part4(53, 23, 1002);
    }

    static private void Part1()
    {
        Console.WriteLine("Velkommen!");
    }

    static private void Part2(string navn)
    {
        Console.WriteLine($"Velkommen til {navn}");
    }

    static private int Part3()
    {
        Console.WriteLine("Skriv et helt tal");
        var tal = Console.ReadLine();

        if (tal == null)
        {
            Console.WriteLine("Noget gik galt");
        }

        int.TryParse(tal, out int x);

        return x;
        // Hvis man ikke skriver et helt tal får man bare 0
    }

    static private void Part4(int one, int two, int three)
    {
        Console.WriteLine($"Før: a = {one}, b = {two}, c = {three}");

        // Kalder metoden med ref-parameter
        SorterTre(ref one, ref two, ref three);

        Console.WriteLine($"Efter: a = {one}, b = {two}, c = {three}");
    }
    static void SorterTre(ref int x, ref int y, ref int z)
    {
        if (x > y) (x, y) = (y, x);
        if (x > z) (x, z) = (z, x);
        if (y > z) (y, z) = (z, y);
    }
}