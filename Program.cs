using System;

namespace groupGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int amount = 6;
            int[] lotto = new int[7];
            Random rand = new Random();

            for (int i = 0; i <= amount; i++)
            {
                int temp = rand.Next(1, 8);

                bool check = true;
                while (check)
                {
                    bool valid = true;
                    foreach (int j in lotto)
                    {
                        if (j == temp)
                        {
                            valid = false;
                        }
                    }
                    if (!valid)
                    {
                        temp = rand.Next(1, 8);
                    }
                    else
                    {
                        check = false;
                    }
                }
                lotto[i] = temp;
            }

            foreach (int j in lotto)
            {
                Console.WriteLine($"{j}");
            }
            Console.ReadLine();

            string[] cities = { "Dunedin", "Auckland", "Wellington", "Christchurch" };
            foreach (string city in cities)
            { 
                Console.WriteLine(city);
            }

            Console.WriteLine("Rhys be writing here");
            int flipCount, flips=0;
            Random random = new Random();

            flipCount = random.Next(20);
            Console.WriteLine("Flipping");
            Thread.Sleep(500);
            while (flips < flipCount)
            {
                Console.Clear();
                Console.WriteLine(" -");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(" \\ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(" |");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(" /");
                Thread.Sleep(200);
                flips = flips + 1;
            }
            Console.WriteLine("git, I hate you too");
            Console.ReadLine();

        }
    }
}
