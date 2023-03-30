using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieceNamespace
{
    internal class PieceVitesse : Piece
    {
        public string Type { get; set; }

        public PieceVitesse() : base()
        {
            Type = "vitesse";
        }

        public override string ToString()
        {
            return $"type : {Type}";
        }
    }
}
