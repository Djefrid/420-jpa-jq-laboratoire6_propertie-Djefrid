using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VilleNamespace
{
    internal class Ville
    {
        public string Nom { get; set; }
        public Batiment[] Batiments { get; set; }

        public Ville() 
        {
            Nom = "Montreal";

            Batiments = new Batiment[5];

            Batiments[0] = new Batiment();
            Batiments[1] = new Batiment(StatutBatiment.doit_etre_demoli,1,quantiteDeRessource : 800);
            Batiments[2] = new Batiment(StatutBatiment.besoinDeResource, 6,quantiteDeRessource : 500);
            Batiments[3] = new Batiment(StatutBatiment.parfait,10);
            Batiments[4] = new Batiment(StatutBatiment.doit_etre_demoli,3,quantiteDeRessource : 700);
        }

        public Ville(string nom,Batiment[] batiment)
        {
            Nom = nom;
            Batiments = batiment;
        }

        public Batiment GetBatiment(int nbre)
        { return Batiments[nbre]; }

    }
}
