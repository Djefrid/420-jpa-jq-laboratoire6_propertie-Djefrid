using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using ChatNamespace;
using ChienNamespace;


namespace AmitieNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat chat1 = new Chat
            {
                Nom = "Cat",
                Humeur = "fachée"
            };

            Chat chat = new Chat
            {
                Nom = "Cat",
                Humeur = "joyeux"
            };

            Chien chien1 = new Chien
            {
                Nom = "Dog",
                Humeur = "joyeux"
            };

            Chien chien2 = new Chien
            {
                Nom = "Doggy",
                Humeur = "joyeux"
            };

            if (chat1.Humeur == "fachée" && chien1.Humeur == "joyeux")
            {
                chat1.MeilleurAmie = "aucun";
                Console.WriteLine($"{chat1.Nom} n'a {chat1.MeilleurAmie} meilleur amie");
            }
            if (chat.Humeur == "joyeux" && chien1.Humeur == "joyeux")
            {
                chat.MeilleurAmie = chien1.Nom;
                Console.WriteLine($"{chat.MeilleurAmie} devient l'amie de {chat.Nom}");
            }
            if (chat.Humeur == "joyeux" && chien1.Humeur == "joyeux")
            {
                chien1.MeilleurAmie = chat.Nom;
                Console.WriteLine($"{chien1.MeilleurAmie} devient l'amie de {chien1.Nom}");
            }
            if (chien1.MeilleurAmie != "" && chat.MeilleurAmie !="")
            {
                chien2.MeilleurAmie = "aucun";
                Console.WriteLine($"{chien2.Nom} n'a {chien2.MeilleurAmie} d'amie");
            }
            
            chien1.Humeur = "fachée";

            if(chien1.Humeur == "fachée")
            {
                chien1.MeilleurAmie = chien2.Nom;
                Console.WriteLine($"c'est maintenant {chien1.MeilleurAmie} le nouvelle meilleur ami de {chien1.Nom}");
            }

        }
    }
}
