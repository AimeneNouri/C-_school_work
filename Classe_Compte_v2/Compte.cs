using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetCompte_Bancaire
{
    class Compte
    {
        private readonly int numero;
        private MAD solde;
        private readonly Client Proprietaire;
        private static int nbr_comptes = 0;
        private static readonly MAD plafond = new MAD(50000);

        public Compte(MAD solde, Client Proprietaire)
        {
            nbr_comptes++;
            numero = nbr_comptes;
            this.solde = solde;
            this.Proprietaire = Proprietaire;
        }
        public void Crediter(MAD somme)
        {
            solde += somme;
            Console.Out.WriteLine("Opération bien effectuée\n");
        }
        public void Debiter(MAD somme)
        {
            if (plafond >= somme)
            {
                solde -= somme;
                Console.Out.WriteLine("Opération bien effectuée\n");
            }
            else
                Console.Out.WriteLine("Votre solde est insuff\n");
        }
        public void Verser(Compte C, MAD somme)
        {
            if (plafond >= somme)
            {
                solde -= somme;
                C.solde += somme;
                Console.Out.WriteLine("Opération bien effectuée\n");
            }
            else
                Console.Out.WriteLine("Votre solde est insuff\n");
        }
        public void Consulter()
        {
            Console.Out.WriteLine("Consulation du compte n°" + numero);
            solde.afficher();
            Console.Out.WriteLine("Propriétaire du compte est : ");
            Proprietaire.afficher();
            Console.Out.WriteLine();
        }
    }
}
