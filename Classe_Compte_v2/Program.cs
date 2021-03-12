using System;

namespace ProjetCompte_Bancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1 = new Compte(new MAD(8000), new Client("Nouri", "Aimene", "CASABLANCA"));
            c1.Consulter();

            Compte c2 = new Compte(new MAD(10000), new Client("Nouri", "Hassan", "CASABLANCA"));
            c2.Consulter();

            c1.Crediter(new MAD(800));
            c1.Consulter();

            c1.Debiter(new MAD(800));
            c1.Consulter();

            c1.Verser(c2, new MAD(800));
            c1.Consulter();
            c2.Consulter();

            Console.ReadKey();
        }
    }
}
