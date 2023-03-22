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

            if (chat1.Humeur == chien1.Humeur)
                Console.WriteLine($"{chat.Nom} et {chien1.Nom} sont amie");
            else
                Console.WriteLine($"{chat.Nom} et {chien1.Nom} ne sont pas des amie");

            if (chat.Humeur == chien1.Humeur)
                Console.WriteLine($"{chat.Nom} et {chien1.Nom} sont amie");
            else
                Console.WriteLine($"{chat.Nom} et {chien1.Nom} ne sont pas des amie");

        }
    }
}
