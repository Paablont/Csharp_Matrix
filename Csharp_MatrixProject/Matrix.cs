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

        //Metodos de turno de cada jugador(Neo, Smith, PersonajeGenerico
        //Quizás con el objeto de c pueda hacer is (instanceof) y según que clase sea hago X,Y o Z

        //Metodo del turno de Neo
        public Character[,] neoTurn(Character[] charactersArray, Character[,] board)
        {
            Neo neo = null;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].name.Equals("Neo"))
                        {
                            neo = (Neo)board[i, j];
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
                        }
                    }
                }
            }



            return board;
        }

        public Character[,] charactTurn(Character[] charactersArray, Character[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (!board[i, j].name.Equals("Neo") && !board[i, j].name.Equals("Smith"))
                        {
                            c = board[i, j];
                            
                        }
                    }
                }
            }

            return board;

        }

        public Character[,] smithTurn(Character[] charactersArray, Character[,] board)
        {

            Smith smith = null;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].name.Equals("Smith"))
                        {
                            smith = (Smith)board[i, j];

                            smith.smithMove(board);
                            smith.killCharacter(board);



                        }
                    }
                }
            }


            return board;
        }

    }
}
