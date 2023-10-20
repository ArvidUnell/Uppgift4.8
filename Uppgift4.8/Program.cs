using System;
namespace Uppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 strängar på varsin rad, den andra ska vara exakt 2 tecken");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            if (str1.Contains(str2[0]) && str1.Contains(str2[1]))
            {
                Console.WriteLine("Båda tecknen i den andra strängen förkommer i den första strängen.");
            }
            else
            {
                Console.WriteLine("Inga/bara ett av tecknen i den andra strängen förekommer i den första strängen");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}