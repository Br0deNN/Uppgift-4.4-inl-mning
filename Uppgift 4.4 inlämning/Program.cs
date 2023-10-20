using System;
using System.Xml.Linq;

namespace inlämning_4._4
{
    class Program
    {
        static void Main(string[] args) 
        {
            string svar = "";

            while( svar != "3" )
            {
                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("1. Subrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett anant");
                Console.WriteLine("3. Avsluta programmet");
                svar = Console.ReadLine();

                switch ( svar )
                {
                    case "1":
                        Console.WriteLine("Skriv in två tal såhär 10 5");
                        string sa = Console.ReadLine();
                        string[] sb = sa.Split(" ");

                        int sa2 = int.Parse(sb[0]);
                        int sb2 = int.Parse(sb[1]);
                        int sum = sa2 - sb2;

                        Console.WriteLine("Svaret av subrationen är " + sum);

                        break;

                    case "2":
                        Console.WriteLine("Skriv in två tal såhär 10 5");
                        string da = Console.ReadLine();
                        string[] db = da.Split(" ");

                        int da2 = int.Parse(db[0]);
                        int db2 = int.Parse(db[1]);
                        int dsum = da2 / db2;

                        Console.WriteLine("Svaret av divitionen är " + dsum);

                        break;

                    case "3":
                        Console.WriteLine("Programmet avslutas");
                        break;

                    default: Console.WriteLine("Välj ett av alternativen");
                        break;
                }
            }
            Console.ReadKey();
           

        }
    }
}