namespace Uppgift_6._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RitaKvadrat(4, 'A');
            RitaKvadrat(3, 'B', 3);

            Console.ReadKey();
        }

        static void RitaKvadrat(int rader, char tecken, int mellanslag)
        {
            for (int i = 0; i < rader; i++)
            {
                for (int j = 0; j < rader; j++)
                {
                    Console.Write(tecken);
                    for (int k = 0; k < mellanslag; k++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void RitaKvadrat(int rader, char tecken)
        {
            for (int i = 0; i < rader; i++)
            {
                for (int j = 0; j < rader; j++)
                {
                    Console.Write(tecken);
                }
                Console.WriteLine();
            }
        }
    }
}