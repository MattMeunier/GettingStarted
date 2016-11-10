using System;

namespace SayMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez votre nom : ");

            // Saisie du nom par l'utilisateur et affiche message d'accueil
            string name = Console.ReadLine();
            Console.WriteLine("Bonjour " + name);

            Console.WriteLine("Quand êtes-vous né(e) : ");

            // Saisie année de naissance par l'utilisateur
            string year = Console.ReadLine();

            // Calcule l'age de l'utilisateur et affiche message conditionné
            int yearNum = int.Parse(year);
            int age = DateTime.Now.Year - yearNum;
            string mess;
            if (age < 40)
            {
                mess = "ça va gamin ?";
            } else if (age < 60) {
                mess = "bientôt la quille !";
            } else
            {
                mess = "en vacances à durée indéterminée !";
            }

            Console.WriteLine("Vous avez " + age.ToString() + " ans, " + mess);

            // Attente saisie pour fermer console
            Console.ReadLine();
        }
    }
}
