using PieceNamespace;
using RobotNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotNamespace
{
    internal class RobotDeDestruction : Robot
    {
        public RobotDeDestruction( Piece piece1, Piece piece2, Piece piece3, int quantiteDeResource) : base(piece1, piece2, piece3, quantiteDeResource)
        {

        }

        public RobotDeDestruction( Piece[] piece, int quantiteDeResource) : base( piece, quantiteDeResource)
        {

        }

        public override string ToString()
        {
            return $"robot de destruction \nquantite de resouce : {QuantiteDeResource} \npiece 1  {Pieces[0]}  \npiece 2  {Pieces[1]}  \npiece 3 {Pieces[2]}";
        }
    }
}
