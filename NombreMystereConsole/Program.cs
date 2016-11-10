using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreMystereConsole
{
    class Program
    {
        static string welcome = "Saisir un nombre entre 0 et 20 : ";
        static string wrongInput = "Oups, saisie incorrecte... C'est à toi : ";
        static string messSup = "Plus grand";
        static string messInf = "Plus petit";
        static string messWin = "Bravo, tu as trouvé en ";
        static int iterator = 1;
        static int input;
        static int num;

        static void Main(string[] args)
        {
            num = new Random().Next(0, 20);
            newGame();
            Console.ReadKey();
        }

        static private void newGame()
        {
           input = picked();
           test(input, num);
        }

        static private int picked()
        {
            Console.WriteLine(welcome);

            int input;
            bool isNum = int.TryParse(Console.ReadLine(), out input);

            while (isNum == false || input>20)
            {
                Console.WriteLine(wrongInput);
                newGame();
            }
            return input;
        }

        static private void test(int input, int num)
        {
            while (num != input)
            {
                if (num < input)
                {
                    Console.WriteLine(messInf);
                }
                else
                {
                    Console.WriteLine(messSup);

                }
                iterator++;
                input = picked();
            }
            Console.WriteLine(messWin + iterator + " coups");
        }
    }
}
