using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Humanizer;
using Humanizer.Inflections;
using Console = Colorful.Console;
using Figgle;
using Alba;
using Alba.CsConsoleFormat.Fluent;

namespace partie2
{
    internal class Program
    {
        public static void TestHumaain()
        {
            string date = "J'etais au cour d'anglais " + DateTime.Now.AddHours(-2).Humanize();
            Console.WriteLine(date);

            string table = "Table";
            Console.WriteLine(table.Pluralize());

            Vocabularies.Default.AddIrregular("Tableau","Tableaux");

            string tableau = "Tableau";
            Console.WriteLine(tableau.Pluralize());

            Console.WriteLine(523696889.ToWords());

            string anniv ="l'anniv d'arnold est " + new DateTime(2003,5,2).ToOrdinalWords();

            Console.WriteLine(anniv);


        }

        public static void TestConsole() 
        {
            int DA = 244;
            int V = 212;
            int ID = 255;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteAscii("INCROYABLE", Color.FromArgb(DA, V, ID));

                DA -= 18;
                V -= 36;
            }



            ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
            ColorAlternator alternator = alternatorFactory.GetAlternator(new[] { "Dog", "m[a-z]+w" }, Color.Plum, Color.PaleVioletRed);

            for (int i = 0; i < 15; i++)
            {
                string catMessage = "cats";

                if (i % 2 == 0)
                {
                    catMessage = "Doggy";
                }
                else if (i % 5 == 0)
                {
                    catMessage = "Dog";
                }

                Console.WriteLineAlternating(catMessage, alternator);
            }

            Console.WriteLine();

            string date = "J'etais au cour d'anglais " + DateTime.Now.AddHours(-2).Humanize();
            Console.WriteLine(date, color: Color.Wheat);

            Console.WriteLine();
        }

        public static void TestFiggle()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Hello, World!"));
            Console.WriteLine();
        }

        public static void TestAlba() 
        {
            Colors.WriteLine("Hello".Red(), "\n", "world!".Yellow());
        }

        static void Main(string[] args)
        {
            TestConsole();
            TestHumaain();
            TestFiggle();
            TestAlba();
            Console.ReadKey();
        }
    }
}
