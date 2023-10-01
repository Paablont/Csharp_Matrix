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

        //Turno del personaje
        public Character[,] charactTurn(List<Character> charactersList, Character[,] board)
        {
            Character.charDeath(charactersList, board);

            return board;

        }

        //Metodo de turno de Neo
        public Character[,] neoTurn(List<Character> charactersList, Character[,] board)
        {
            Neo neo = Matrix.obtainNeo(board);
            bool chosenOne = neo.theChosenOne();
            //Compruebo si es el elegido para que genere un nuevo personaje cerca de el o no
            if (chosenOne)
            {
                neo.charNeoGenerate(charactersList, board);
                neo.neoMove(board);
            }
            else
            {
                neo.neoMove(board);
            }

            return board;
        }


        //Metodo de turno de Smith
        public Character[,] smithTurn(Character[,] board)
        {

            Smith smith = Matrix.obtainSmith(board);
            smith.smithMove(board);


            return board;
        }


        //Metodo para buscar a Neo en board
        public static Neo obtainNeo(Character[,] board)
        {
            Neo neo = null;
            bool found = false;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) && !found; j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].Name.Equals("Neo"))
                        {
                            neo = (Neo)board[i, j];
                            found = true;
                            neo.Latitude = i;
                            neo.Longitude = j;

                        }
                    }
                }
            }
            return neo;
        }


        //Metodo para buscar a Smith en board
        public static Smith obtainSmith(Character[,] board)
        {
            Smith sm = null;
            bool found = false;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) && !found; j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].Name.Equals("Smith"))
                        {
                            sm = (Smith)board[i, j];
                            found = true;
                            sm.Latitude = i;
                            sm.Longitude = j;

                        }
                    }
                }
            }
            return sm;
        }


    }
}
