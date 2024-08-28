namespace Afsnit16;

public class Bog(string titel, string forfatter, int pris)
{
    public string Titel { get; set; } = titel;
    public string Forfatter { get; set; } = forfatter;
    public int Pris { get; set; } = pris;

    // Constructor

    // Opdateret metode: HarRåd
    public bool HarRåd(int penge)
    {
        return penge >= Pris;
    }
}


class Program
{
    public static void Main()
    {
        Bog sherlockHolmes = new Bog("Sherlock Holmes", "Arthur Conan Doyle", 150);

        Console.WriteLine($"{sherlockHolmes.Titel} - koster {sherlockHolmes.Pris} kr.");

        int pengeTilAtKøbe = 200;
        int pengeIkkeTilAtKøbe = 100;

        Console.WriteLine(sherlockHolmes.HarRåd(pengeTilAtKøbe) ? $"Jeg har råd med {pengeTilAtKøbe}" : $"Jeg har desværre ikke råd med {pengeIkkeTilAtKøbe}");
        Console.WriteLine(sherlockHolmes.HarRåd(pengeIkkeTilAtKøbe) ? $"Jeg har råd med {pengeIkkeTilAtKøbe}" : $"Jeg har desværre ikke råd med {pengeIkkeTilAtKøbe}");
    }
};