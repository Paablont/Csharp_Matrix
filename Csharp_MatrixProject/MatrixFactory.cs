using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{

    internal class MatrixFactory
    {

        Matrix m = new Matrix();


        public MatrixFactory() { }



        //Metodo para crear la matrix (board)
        public Character[,] matrixCreation(List<Character> charactersList)
        {
            Character[,] board = new Character[m.Raws, m.Cols];

            Random rnd = new Random();
            bool foundNeo = false;
            bool foundSmith = false;
            //Metemos a neo y smith en la matriz
            board[charactersList[0].Latitude, charactersList[0].Longitude] = charactersList[0];
            charactersList.RemoveAt(0);
            board[charactersList[0].Latitude, charactersList[0].Longitude] = charactersList[0];
            charactersList.RemoveAt(0);

            Neo n = Matrix.obtainNeo(board);
            Smith sm = Matrix.obtainSmith(board);

            //Generamos a un aleatorio para coger X personajes de la lista
            int aleatorio = rnd.Next(10, m.Raws * m.Cols - 2);

            //Los metemos en el board
            for (int i = 2; i < charactersList.Count && i < aleatorio; i++)
            {
                //Comprobamos que la posicion donde van es null
                if (board[charactersList[0].latitude, charactersList[0].longitude] == null)
                {
                    board[charactersList[0].latitude, charactersList[0].longitude] = charactersList[i];

                }
               
                charactersList.RemoveAt(0);
            }

            ////Compruebo que Neo ha entrado correctamente en la matriz
            //for (int i = 0; i < board.GetLength(0); i++)
            //{
            //    for (int j = 0; j < board.GetLength(1); j++)
            //    {
            //        if (board[i, j] != null && board[i, j] is Neo)
            //        {
            //            foundNeo = true;
            //        }
            //    }
            //}

            ////Compruebo que Smith ha entrado correctamente en la matriz
            //for (int i = 0; i < board.GetLength(0); i++)
            //{
            //    for (int j = 0; j < board.GetLength(1); j++)
            //    {
            //        if (board[i, j] != null && board[i, j] is Smith)
            //        {
            //            foundSmith = true;
            //        }
            //    }
            //}



            return board;
        }

        //Metodo para imprimir tablero
        public void boardPrint(Character[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].Name.Equals("Neo"))
                        {
                            Console.Write("[Neo]\t");

                        }
                        else if (board[i, j].Name.Equals("Smith"))
                        {
                            Console.Write("[Smi]\t");

                        }
                        else
                        {
                            Console.Write("[C]\t");
                        }


                    }
                    else
                    {
                        Console.Write("[ ]\t");
                    }


                }
                Console.WriteLine();

            }


        }


    }
}
