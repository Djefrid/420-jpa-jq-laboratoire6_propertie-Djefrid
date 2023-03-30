using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieceNamespace
{
    internal class PieceTransport : Piece
    {
        public string Type { get; set; }

        public PieceTransport() : base() 
        {
            Type = "transport";
        }

        public override string ToString()
        {
            return $"type : {Type}";
        }
    }
}
