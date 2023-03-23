using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieceNamespace
{
    enum Partie
    {
        tete,
        bras,
        corps,
        jambe,
    }

    enum Alliage
    {
        bronze,
        fer,
        acier,
        adamantium,
    }

    internal class Piece
    {
        protected string Non { get; set; }
        protected int Resistance { get; set; }
        protected int Force { get; set; }
        protected Partie Partie { get; set; }
        protected Alliage Alliage { get; set; }

        public Piece()
        {

        }

        public Piece(string non, int resistance, Alliage alliage = Alliage.acier ,int force = 13)
        {
            Non = non;
            Resistance = resistance;
            Force = force;
            Alliage = alliage;
        }
    }
}
