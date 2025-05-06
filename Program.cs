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
                //for (int j = 0; j <= i; j++) // while loop that gets exited manually if it detects same number in array and then restarts the check 
                //{
                //    while (lotto[j] == temp) 
                //    {
                //        temp = rand.Next(1, 8);
                //    }
                //}
                lotto[i] = temp;
            }

            foreach (int j in lotto)
            {
                Console.WriteLine($"{j}");
            }
            Console.ReadLine();

            Console.WriteLine("My Name is Kavarn");
            Console.WriteLine("I am 24");
            Console.WriteLine("I don't");
            Console.WriteLine("know what else to");
            Console.WriteLine("write");

            Console.WriteLine("Rhys be writing here");
            Console.WriteLine("and still writing");
            Console.WriteLine("mayhaps writing a little more");
            Console.WriteLine("and more");
            Console.WriteLine("and more once again");
            Console.ReadLine();

        }
    }
}
