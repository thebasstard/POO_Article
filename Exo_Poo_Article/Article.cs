using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Poo_Article
{
    class Article
    {
        private int reference;
        private string designation;
        private double prixHT;
        private static double tauxTVA;            //Attribut statique

        public int Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public double PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }

        public static double TauxTVA                             //propriété statique
        {
            get { return tauxTVA; }
            set { tauxTVA = value; }
        }

        public Article() { }                                       //Constructeur par défaut


        //permet de renseigner la référence et la désignation lors de l’instanciation
        public Article(int r, string d)                             //Constructeur surchargé
        {
            reference = r;
            designation = d;
        }

        public Article(Article a)                                  //Constructeur de recopie
        {
            reference = a.reference;
            designation = a.designation;
            prixHT = a.prixHT;

        }

        public Article(int r, string d, double p)         //Constructeur d'initialisation
        {
            reference = r;
            designation = d;
            prixHT = p;

        }

        public double CalculerPrixTTC()
        {
            return prixHT * (1 + tauxTVA / 100);
        }

        public void AfficherArticle()
        {
            Console.Out.WriteLine("Référence : " + reference);
            Console.Out.WriteLine("Désignation : " + designation);
            Console.Out.WriteLine("Prix HT : " + prixHT);
        }
        
    }
}
