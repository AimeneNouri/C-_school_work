using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetCompte_Bancaire
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;

        public Client(string nom, string prenom, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }
        public void afficher()
        {
            Console.Out.WriteLine("Nom: " + nom);
            Console.Out.WriteLine("Prénom: " + prenom);
            Console.Out.WriteLine("Adresse: " + adresse);
        }
    }
}
