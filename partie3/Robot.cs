using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PieceNamespace;

namespace RobotNamespace
{
    enum TypeDeRobot
    {
        construction,
        destruction,
        evaluation,
        transport,
    }

    internal class Robot
    {
        protected int QuantiteDeResource { get; set; }
        protected Piece[] Pieces { get; set; }

        public Robot(Piece piece1,Piece piece2,Piece piece3, int quantiteDeResource)
        {
            QuantiteDeResource = quantiteDeResource;
            Pieces = new Piece[3];

            Pieces[0] = piece1 ; 
            Pieces[1] = piece2 ; 
            Pieces[2] = piece3 ;
        }

        public Robot(Piece[] piece, int quantiteDeResource)
        {
            Pieces = piece;
            QuantiteDeResource = quantiteDeResource;
        }
    }
}
