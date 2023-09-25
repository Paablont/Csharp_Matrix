using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    //sisisisiisis
    internal class MatrixFactory
    {

        Matrix m = new Matrix();


        public MatrixFactory() { }



        //Metodo para crear la matrix
        public Character[,] matrixCreation(Character[] charactersArray, Character[,] board)
        {
            Random rnd = new Random();
            bool foundNeo = false;
            bool foundSmith = false;
            /*
            He creado un int con random que genere un numero del 1 al tamaño del tablero
            para que meta X personajes. Si no controlo esto, los 200 personajes no caben en el tablero
            (Bueno si caben pero si el tablero fuera mas pequeño no)
             */
            int charactersInMatrix = rnd.Next(1, charactersArray.Length);

            do
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {

                    for (int j = 0; j < charactersInMatrix; j++)
                    {

                        board[charactersArray[j].latitude, charactersArray[j].longitude] = charactersArray[j];

                    }

                    break;
                }

                foreach (Character c in board)
                {
                    if (c != null)
                    {
                        if (c.name.Equals("Neo"))
                        {
                            foundNeo = true;
                            break;
                        }
                    }
                    
                }

                foreach (Character c in board)
                {
                    if(c != null)
                    {
                        if (c.name.Equals("Smith"))
                        {
                            foundSmith = true;
                            break;
                        }
                    }
                }
            } while (!foundNeo && !foundSmith);
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
                        if (board[i, j].name.Equals("Neo"))
                        {
                            Console.Write("[N]\t");

                        }
                        else if (board[i, j].name.Equals("Smith"))
                        {
                            Console.Write("[S]\t");

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
