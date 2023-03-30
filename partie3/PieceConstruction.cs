using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieceNamespace
{
    internal class PieceConstruction : Piece
    {
        public string Type { get; set; }

        public PieceConstruction() : base()
        {
            Type = "construction";
        }

        public override string ToString()
        {
            return $"type : {Type}";
        }
    }
}
