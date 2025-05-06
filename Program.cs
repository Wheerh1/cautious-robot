namespace groupGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Sam");
            Console.WriteLine("I like green eggs and Ham");
            Console.WriteLine("I am writing some");
            Console.WriteLine("words here for");
            Console.WriteLine("everyone to see!");

            string[] cities = { "Dunedin", "Auckland", "Wellington", "Christchurch" };
            foreach (string city in cities)
            { 
                Console.WriteLine(city);
            }

            Console.WriteLine("Rhys be writing here");
            Console.WriteLine("and still writing");
            Console.WriteLine("mayhaps writing a little more");
            Console.WriteLine("and more");
            Console.WriteLine("and more once again");
            Console.ReadLine();

        }
    }
}
