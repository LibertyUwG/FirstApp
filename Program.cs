using System;
using System.Threading;


/* 
            Console.Title = "FirstApp"; -- Titre
            Console.Read(); -- Mets en pause
            Console.WriteLine("Hello World!"); --WriteLine + Retour
            Thread.Sleep(2000); -- Sleep ~2 secondes
*/

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "";
            Console.WriteLine("Type your Username:");
            test = Console.ReadLine();
            bool isAdmin = false;
            bool isModerateur = false;
            string Rank = "Utilisateur";



            while (test == "")
            {

                Console.WriteLine("Utilisateur invalide.");
                test = Console.ReadLine();
            }


            if (test == "Liberty" || test == "Canvenante")

            {
                isAdmin = true;
                if(isAdmin)
                {
                    Rank = "SuperAdmin";
                }
                Console.WriteLine("Rang: "+Rank);
                Console.WriteLine("Bienvenue à vous " + test);
                Thread.Sleep(2000);
            }
            else if (test == "Neo" || test == "Gray")
            {
                isModerateur = true;
                if (isModerateur)
                {
                    Rank = "Modérateur";
                    if (test == "Neo")
                    {
                        Rank = "Jean-Mich SuperModo";
                    }
                }
                Console.WriteLine("Rang: "+Rank);
                Console.WriteLine("Bienvenue à vous " + test);
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Rang: "+Rank);
                Console.WriteLine("Bienvenue: "+ test);
                Thread.Sleep(2000);

            }

        }
    }
}