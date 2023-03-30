using PieceNamespace;
using RobotNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VilleNamespace;

namespace RobotNamespace
{
    internal class RobotDeConstruction : Robot
    {
        public RobotDeConstruction(Piece piece1, Piece piece2, Piece piece3, int quantiteDeResource) : base(piece1, piece2, piece3, quantiteDeResource)
        {

        }

        public RobotDeConstruction(Piece[] piece, int quantiteDeResource) : base(piece, quantiteDeResource)
        {

        }

        public override string ToString()
        {
            return $"robot de construction \nquantite de resouce : {QuantiteDeResource} \npiece 1  {Pieces[0]}  \npiece 2  {Pieces[1]}  \npiece 3 {Pieces[2]}";
        }
    }
}
