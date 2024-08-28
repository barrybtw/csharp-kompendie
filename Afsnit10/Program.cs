namespace Afsnit10;

class Program
{
    static void Main(string[] args)
    {
        int x = 42;
        int y = 64;

        if (x + y > 100)
        {
            Console.WriteLine("Summen er større end 100");
        }
        else
        {
            Console.WriteLine("Summen er mindre end 100");
        }
        
        // Del 2

        int dice = new Random().Next(0, 6);

        if (dice == 1)
        {
            Console.WriteLine("Ener");
        } else if (dice == 2)
        {
            Console.WriteLine("Toer");
        } else if (dice == 3)
        {
            Console.WriteLine("Treer");
        } else if (dice == 4)
        {
            Console.WriteLine("Fier");
        } else if (dice == 5)
        {
            Console.WriteLine("Femer");
        } else if (dice == 6)
        {
            Console.WriteLine("Sekser");
        }
        else
        {
            Console.WriteLine("Magisk terning");
        }
    }
}