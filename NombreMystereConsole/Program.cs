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
        static string messNewGame = "Nouvelle partie ? o/n";
        static int iterator;
        static int num;
        static int inputInt;

        static void Main(string[] args)
        {
            newGame();
            Console.ReadKey();
        }

        static private void newGame()
        {
            num = new Random().Next(0, 20);
            iterator = 0;
            Console.WriteLine(welcome);

            inputInt = play();
            test(inputInt, num);
            retry();
        }

        static private int play()
        {
            string inputString;
            inputString = picked();
            inputInt = verify(inputString);
            return inputInt;
        }

        static private string picked()
        {
            iterator++;
            string input = Console.ReadLine();
            return input;
        }

        static private int verify(string input)
        {
            int inputOut;
            while (int.TryParse(input, out inputOut) == false)
            {
                Console.WriteLine(wrongInput);
                input = picked();
            }
            return inputOut;
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
                input = play();
            }
            Console.WriteLine(messWin + iterator + " coups");
        }

        private static void retry()
        {
            Console.WriteLine(messNewGame);
            switch (Console.ReadLine())
            {
                case "o":
                    newGame();
                    break;
                case "n":
                    Environment.Exit(1);
                    break;
                default:
                    retry();
                    break;
            }
        }
    }
}
