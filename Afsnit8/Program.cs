namespace Afsnit8;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        counter += 5;
        counter++;

        Console.WriteLine(counter);
        
        // ++counter eller counter++ har egentlig ingen forskel, dog hvis man gør det i en console writeline funktion
        // vil ++ evalueres før den printes og derfor vise den nye værdi, men counter++ vil først printe værdien og så tilføje 1
    }
}