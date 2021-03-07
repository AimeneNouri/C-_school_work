using System;

namespace Classe_Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1 = new Compte(1800, new Client("Nouri", "Aimene", "CASABLANCA"));
            c1.afficher();

            Compte c2 = new Compte(180000, new Client("Nouri", "Hassan", "CASABLANCA"));
            c2.afficher();

            //Crediter un compte
            Console.Out.WriteLine("\nCrediter le Compte");
            c1.Crediter(c2, 1600);

            Console.Out.WriteLine("\nApres le credit: ");
            c1.afficher();
            c2.afficher();

            //Debiter un compte
            Console.Out.WriteLine("\nDebiter le Compte");
            c1.Debiter(c2, 1600);

            Console.Out.WriteLine("\nApres le debit: ");
            c1.afficher();
            c2.afficher();

            Console.ReadKey();
        }
    }
}
