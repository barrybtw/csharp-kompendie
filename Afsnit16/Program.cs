namespace Afsnit16;

public class Bog(string titel, string forfatter, int pris)
{
    public string Titel { get; set; } = titel;
    public string Forfatter { get; set; } = forfatter;
    public int Pris { get; set; } = pris;

    public bool HarRåd(int bogensPris, int penge)
    {
        return penge >= bogensPris;
    }
}

class Program
{
    public static void Main()
    {
        Bog sherlockHolmes = new Bog("Sherlock Holmes", "Arthur Conan Doyle", 150);

        int pengeTilAtKøbe = 200;
        int pengeIkkeTilAtKøbe = 100;

        Console.WriteLine(sherlockHolmes.HarRåd(150, pengeTilAtKøbe) ? "Jeg har råd" : "Jeg har desværre ikke råd");
        Console.WriteLine(sherlockHolmes.HarRåd(150, pengeIkkeTilAtKøbe) ? "Jeg har råd" : "Jeg har desværre ikke råd");
    }
}