using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotNamespace;
using VilleNamespace;
using PieceNamespace;
using Console = Colorful.Console;
using System.Drawing;

namespace partie3
{
    enum TacheaFaire
    {
        conctruction,
        transport,
        destruction,
        explorer
    }


    internal class Simulateur
    {
        public Usine Usine { get; set; }
        public Ville Ville { get; set; }

        public Simulateur()
        {
            Ville = new Ville();
            Usine = new Usine();
        }

        public Batiment Explore(int nbre)
        {
            return Ville.GetBatiment(nbre);
        }

        public int VerifierSaisie()
        {
            int nombre;
            bool nombreValide;
            do
            {
                Console.WriteLine($"entrer un nombre entier");
                nombreValide = int.TryParse(Console.ReadLine(), out nombre);

            } while (!nombreValide && (nombre != 1 || nombre != 2 || nombre != 3));

            return nombre;
        }

        public Robot GererchoixUseur(Batiment batiment, Usine usine, int choix)
        {
            Robot robot = null;

            if (choix == 1)
            {
                robot = usine.CreeRobot(TacheaFaire.conctruction, batiment.QuantiteDeRessource);
            }
            else if (choix == 2)
            {
                robot = usine.CreeRobot(TacheaFaire.destruction, batiment.QuantiteDeRessource);
            }
            else if (choix == 3)
            {
                robot = usine.CreeRobot(TacheaFaire.transport, batiment.QuantiteDeRessource);
            }

            return robot;
        }


        public void GestionDesStatuts(Batiment[] batiments, StatutBatiment[] statutBatiments)
        {
            Console.WriteLine("\nAu debut du jeu la ville avait 5 batiment avec les statut respectif :\n");

            for (int i = 0; i < batiments.Length; i++)
            {
                Console.WriteLine($"Le batiments {i + 1} avait pour statut : {batiments[i].StatutBatiment}");
            }

            Console.WriteLine("\nLes nouveaux statut respectif des 5 batiment de la ville sont :\n");

            for (int i = 0; i < batiments.Length; i++)
            {
                batiments[i].StatutBatiment = statutBatiments[i];
                Console.WriteLine($"Le batiments {i + 1} a pour statut : {batiments[i].StatutBatiment}");
            }
        }

        public void Option(Batiment batiment, int nbre)
        {
            if (batiment.StatutBatiment == StatutBatiment.parfait)
            {
                Console.WriteLine($"\nla statut du batiment {nbre} est : {batiment.StatutBatiment}");
                Console.WriteLine("Vous aveztrouver un batiment parfait nous alloes continuer de parcourir la ville");
            }
            else
            {
                Console.WriteLine($"\nla statut du batiment {nbre} est : {batiment.StatutBatiment}\n");
                Console.WriteLine("Que voulez vous faire : \n\n1 - reparer le batiment  \n2 - detruire le batiment \n3 - envoyer les resource au batiment");
            }
        }


        public void GererReparation(Ville ville, Usine usine)
        {
            StatutBatiment[] statutBatiments = new StatutBatiment[5];
            Batiment[] batiments = ville.Batiments;

            Console.WriteLine($"                ****************** BIENVENUE DANS LA VILLE DE {ville.Nom} ******************\n\n");

            Console.WriteLine($"La ville a {batiments.Length} batiments :\n");

            for (int i = 0; i < batiments.Length; i++)
            {
                Console.WriteLine($"Batiment {i + 1} {batiments[i].ToString()}");
            }

            Console.WriteLine("\n\n*****************************************************");

            for (int i = 0; i < batiments.Length; i++)
            {
                batiments[i] = Explore(i);

                if (batiments[i].StatutBatiment == StatutBatiment.parfait)
                {
                    Option(batiments[i], i + 1);
                    statutBatiments[i] = batiments[i].StatutBatiment;
                }
                else if (batiments[i].StatutBatiment == StatutBatiment.doit_etre_demoli)
                {
                    Option(batiments[i], i + 1);

                    Robot robot = GererchoixUseur(batiments[i], usine, VerifierSaisie());
                    Console.WriteLine(robot.ToString()); 
                    statutBatiments[i] = StatutBatiment.parfait;
                }
                else if (batiments[i].StatutBatiment == StatutBatiment.necessite_Une_reparation)
                {
                    Option(batiments[i], i + 1);

                    Robot robot = GererchoixUseur(batiments[i], usine, VerifierSaisie());
                    Console.WriteLine(robot.ToString());
                    statutBatiments[i] = StatutBatiment.parfait;

                }
                else if (batiments[i].StatutBatiment == StatutBatiment.besoinDeResource)
                {
                    Option(batiments[i], i + 1);

                    Robot robot = GererchoixUseur(batiments[i], usine, VerifierSaisie());
                    Console.WriteLine(robot.ToString());
                    statutBatiments[i] = StatutBatiment.parfait;
                }
            }
            GestionDesStatuts(batiments, statutBatiments);


        }

    }
}
