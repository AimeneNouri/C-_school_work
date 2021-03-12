using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetCompte_Bancaire
{
    class MAD
    {
        private readonly double valeur;

        public MAD(double valeur)
        {
            this.valeur = valeur;
        }

        public static MAD operator +(MAD so1, MAD so2)
        {
            MAD so = new MAD(so1.valeur + so2.valeur);
            return so;
        }
        public static MAD operator -(MAD so1, MAD so2)
        {
            MAD so = new MAD(so1.valeur - so2.valeur);
            return so;
        }
        public static bool operator >=(MAD so1, MAD so2)
        {
            return (so1.valeur >= so2.valeur);
        }
        public static bool operator <=(MAD so1, MAD so2)
        {
            return (so1.valeur <= so2.valeur);
        }
        public void afficher()
        {
            Console.WriteLine("Le solde est " + valeur + " MAD");
        }
    }
}
