using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{

    internal class Matrix

    {
        Character c;
        Smith smith;
        Neo neo;
        private const int raws = 15;
        private const int cols = 15;


        public Matrix()
        {

        }

        public int Raws
        {
            get { return raws; }
        }

        public int Cols
        {
            get { return cols; }
        }

       

        //Turno de Neo
        public Character[,] neoTurn(Character[] charactersArray, Character[,] board)
        {
            Neo neo = Neo.obtainNeo(board);

            if (neo.theChosenOne())
            {
                Console.WriteLine("ELEGIDO");
                neo.charNeoGenerate(charactersArray, board);
                neo.neoMove(board);
            }
            else
            {
                neo.neoMove(board);
            }
            
            return board;
        }

        //Turno del personaje (REVISAR)
        public Character[,] charactTurn(Character[] charactersArray, Character[,] board)
        {
            c.charDeath(charactersArray, board);
            

            return board;

        }

        public Character[,] smithTurn(Character[,] board)
        {

            Smith smith = Smith.obtainSmith(board);
            smith.smithMove(board);
            smith.smithMove(board);
            smith.smithMove(board);
            //smith.killCharacter(board);
            
            return board;
        }

    }
}
