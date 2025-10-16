namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta täht ja vajuta enter");

                string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    Console.WriteLine("1");
                    break;

                case "e":
                    Console.WriteLine("2");
                        break;

                case "i":
                    Console.WriteLine("3");
                        break;

                default:
                    Console.WriteLine("4");
                    break;
            }
        }
    }
}
