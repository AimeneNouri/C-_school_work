using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Compte
{
    class Compte
    {
        private int numero;
        private double solde;
        private Client Proprietaire;
        private static int nbr_comptes = 0;

        public Compte(double solde, Client Proprietaire)
        {
            nbr_comptes++;
            numero = nbr_comptes;
            this.solde = solde;
            this.Proprietaire = Proprietaire;
        }
        public void Crediter(double somme)
        {
            solde += somme;
            Console.Out.WriteLine("Opération bien effectuée");
        }
        public void Crediter(Compte C, double somme)
        {
            if(C.solde >= somme)
            {
                C.solde -= somme;
                solde += somme;
                Console.Out.WriteLine("Opération bien effectuée");
            }
            else
               Console.Out.WriteLine("Solde du compte est insuff");
        }
        public void Debiter(double somme)
        {
            solde -= somme;
            Console.Out.WriteLine("Opération bien effectuée");
        }
        public void Debiter(Compte C, double somme)
        {
            if (solde >= somme)
            {
                solde -= somme;
                C.solde += somme;
                Console.Out.WriteLine("Opération bien effectuée");
            }
            else
                Console.Out.WriteLine("Votre solde est insuff");
        }
        public void afficher()
        {
            Console.Out.WriteLine("Numéro de Compte: " + numero);
            Console.Out.WriteLine("Solde de compte: " + solde);
            Console.Out.WriteLine("Propriétaire du compte est : ");
                Proprietaire.afficher();
        }
    }
}
