using System.Net.Http.Headers;

namespace kui_ja_siis_harjutus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int auto = 1000;
            int rekka = 5000;

            if (auto < rekka) 
            {
                int vahe = (rekka - auto); 
                Console.WriteLine("auto on " + vahe + " kg kergem kui rekka");
            }
            else
            {
                Console.WriteLine("rekka on raskem kui auto");
            }
        }
    }
}
