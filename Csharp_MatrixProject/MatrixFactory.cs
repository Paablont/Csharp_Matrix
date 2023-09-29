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



        //Metodo para crear la matrix
        public Character[,] matrixCreation(List<Character> charactersArray)
        {
            Character[,] board = new Character[m.Raws, m.Cols];
            int contadorLista = 0;
            Random rnd = new Random();
            bool foundNeo = true;
            bool foundSmith = true;
            /*
            He creado un int con random que genere un numero del 1 al tamaño del tablero
            para que meta X personajes. Si no controlo esto, los 200 personajes no caben en el tablero
            (Bueno si caben pero si el tablero fuera mas pequeño no)
             */
            int charactersInMatrix = rnd.Next(1, 10);

            do
            {
                for (int j = 0; j < charactersArray.Count; j++)
                    {

                        board[charactersArray[j].Latitude, charactersArray[j].Longitude] = charactersArray[0];
                        
                        charactersArray.RemoveAt(0);
                    
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
