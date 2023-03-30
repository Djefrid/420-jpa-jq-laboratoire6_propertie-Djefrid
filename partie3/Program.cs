using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PieceNamespace;
using VilleNamespace;
using RobotNamespace;
using Console = Colorful.Console;

namespace partie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Simulateur simulateur = new Simulateur();

            simulateur.GererReparation(simulateur.Ville,simulateur.Usine);

            
            Console.ReadKey();
        }
    }
}
