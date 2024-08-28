namespace Afsnit6;

class Program
{
    static void Main(string[] args)
    {
        // % er modulus, det returnerer restværdien, for eksempel er 5 % 23 = 3 da 5 går op i 23 4 gange og efterlader 3
        
        // Man må ikke dividere med nul, gælder også for programmering
        
        // 2 + 1 * 2 = 4
        // (2 + 1) * 2 = 6
        // 5 / 2 = 2.5
        // 8 % 3 = 3
        // 1 - 5 = -4

        int x = 5 / 2;

        Console.WriteLine($"{2+1*2}, {(2+1)*2}, {5/2}, {8%3}, {1-5}");
        // Printer ikke kommatal da den umiddelbart har med ints at gøre
        
        Console.WriteLine($"{2F+1F*2F}, {(2F+1F)*2F}, {5F/2F}, {8F%3F}, {1F-5F}");
        // Printer kommatal da vi har med floats at gøre

    }
}