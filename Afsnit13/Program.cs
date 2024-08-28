namespace Afsnit13;

class Program
{
    static void Main(string[] args)
    {
        var rand = new Random();
        int one = rand.Next(0, 100);
        int two = rand.Next(0, 100);
        int three = rand.Next(0, 100);

        int[] t = [one, two, three];

        Console.WriteLine($"Det største tal blandt: {one}, {two} og {three} er {t.Max()}");

        // 2
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }

            Console.WriteLine($"{i} er et lige tal");
        }
    }
}