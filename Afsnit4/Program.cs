namespace Afsnit4;

class Program
{
    static void Main(string[] args)
    {
        float x = 5.5F;
        double y = 5.5;
        char z = 'z';

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        
        // Doubles har højere præcision på 15 decimaltal, men mere hukommelse
        // Floats har kun en præcision på 6-7 decimaltal, men mindre hukommelse
        
        // Bestem hvilken type variabel der skal benyttes, for at kunne indeholde følgende værdier: 1054, -522, 1.234, k, -4.3, y, 19488
        
        // 1054: uint eller int
        // -522 int
        // 1.234 float eller double
        // k char
        // -4.3 float eller double
        // y char
        // 19488 uint eller int
    }
}