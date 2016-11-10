using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreMystereConsole
{
    class Program
    {
        static string messSup = "Plus grand";
        static string messInf = "Plus petit";
        static string messWin = "Bravo, tu as trouvé en ";

        static Random rand = new Random();

        static void Main(string[] args)
        {
            int num = rand.Next(0, 20);
            int input;
            int iterator = 1;
            
            {
                Console.WriteLine("Saisir un nombre entre 0 et 20 : ");
                input = int.Parse(Console.ReadLine());

                while (num != input)
                {
                    if (num < input)
                    {
                        Console.WriteLine(messSup);
                    }
                    else
                    {
                        Console.WriteLine(messSup);

                    }
                    iterator ++;

                }
                Console.WriteLine(messWin + iterator + " coups");
                Console.ReadLine();
            }
            
        }
    }
}
