namespace Afsnit10;

class Program
{
    static void Main(string[] args)
    {
        int dice = new Random().Next(0, 6);

        switch (dice)
        {
            case 1:
                Console.WriteLine("Ener");
                break;
            case 2:
                Console.WriteLine("Toer");
                break;
            case 3:
                Console.WriteLine("Treer");
                break;
            case 4:
                Console.WriteLine("Fier");
                break;
            case 5:
                Console.WriteLine("Femer");
                break;
            case 6:
                Console.WriteLine("Sekser");
                break;
            default:
            {
                Console.WriteLine("Magisk terning!");
                break;
            }
        }
    }
}