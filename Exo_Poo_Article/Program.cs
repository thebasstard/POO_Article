using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Poo_Article
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Out.Write("Donner le taux de TVA pour tous les articles : ");
            Article.TauxTVA = double.Parse(Console.In.ReadLine()); //propriété statique
            Console.Out.WriteLine("Le taux TVA est : " + Article.TauxTVA + "%");

            Console.Out.WriteLine("\n\nArticle 1: ");
            Article A1 = new Article();
            A1.AfficherArticle();
            Console.Out.WriteLine("Le prix TTC est " + A1.CalculerPrixTTC());

            Console.Out.WriteLine("\n\nArticle 2: ");
            int r;
            string d;
            double p;
            Console.Out.Write("Donner la référence: ");
            r = int.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner la désignation: ");
            d = Console.In.ReadLine();
            Console.Out.Write("Donner le prix HT: ");
            p = double.Parse(Console.In.ReadLine());
            Article A2 = new Article(r, d, p);
            A2.AfficherArticle();
            Console.Out.WriteLine("Le prix TTC est " + A2.CalculerPrixTTC());

            Console.Out.WriteLine("\n\nArticle 3: ");
            Console.Out.Write("Donner la référence: ");
            r = int.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner la désignation: ");
            d = Console.In.ReadLine();
            Article A3 = new Article(r, d);
            A3.AfficherArticle();
            Console.Out.WriteLine("Le prix TTC est " + A3.CalculerPrixTTC());

            Console.Out.WriteLine("\n\nArticle 4: ");
            Article A4 = new Article(A2);
            A4.AfficherArticle();
            Console.Out.WriteLine("Le prix TTC est " + A4.CalculerPrixTTC());

            Console.ReadKey();

        }
    }
}
