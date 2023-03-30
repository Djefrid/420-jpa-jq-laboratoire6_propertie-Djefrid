using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using partie3;
using PieceNamespace;
using VilleNamespace;

namespace RobotNamespace
{
    internal class Usine
    {
        public string Nom { get; set; }

        public Usine()
        {

        }

        public Robot CreeRobot(TacheaFaire tacheaFaire, int QuantiteDeRessource)
        {
            Robot robot = null;

            switch (tacheaFaire)
            {
                case TacheaFaire.conctruction:
                    {
                        Piece[] pieces = new Piece[3];
                        pieces[0] = new PieceConstruction();
                        pieces[1] = new PieceConstruction();
                        pieces[2] = new PieceVitesse();

                        RobotDeConstruction robotDeConstruction = new RobotDeConstruction(pieces, QuantiteDeRessource);
                        robot = robotDeConstruction;
                        break;
                    }

                case TacheaFaire.transport:
                    {
                        Piece[] pieces3 = new Piece[3];
                        pieces3[0] = new PieceTransport();
                        pieces3[1] = new PieceTransport();
                        pieces3[2] = new PieceVitesse();

                        RobotDeTransport robotDeTransport = new RobotDeTransport(pieces3, QuantiteDeRessource);
                        robot = robotDeTransport;
                        break;
                    }

                case TacheaFaire.destruction:
                    {
                        Piece[] pieces2 = new Piece[3];
                        pieces2[0] = new PieceDestruction();
                        pieces2[1] = new PieceDestruction();
                        pieces2[2] = new PieceTransport();

                        RobotDeDestruction robotDeDestruction = new RobotDeDestruction(pieces2, QuantiteDeRessource);
                        robot = robotDeDestruction;
                        break;
                    }

                default:
                    {
                        Piece[] pieces1 = new Piece[3];
                        pieces1[0] = new PieceVitesse();
                        pieces1[1] = new PieceVitesse();
                        pieces1[2] = new PieceVitesse();

                        RobotEvaluateur robotEvaluateur = new RobotEvaluateur(pieces1, QuantiteDeRessource);
                        robot = robotEvaluateur;
                        break;
                    }
            }

            return robot;
        }
    }
}
