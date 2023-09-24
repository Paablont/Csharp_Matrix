using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{

    internal class MatrixFactory
    {

        CharacterFactory cf = new CharacterFactory();
        Matrix m = new Matrix();
        public MatrixFactory() { }



        //Metodo para crear la matrix
        public Character[,] matrixCreation(Character[] charactersArray, Character[,] board)
        {
            Random rnd = new Random();
            /*
             He creado un int con random que genere un numero del 1 al tamaño del tablero
            para que meta X personajes. Si no controlo esto, los 200 personajes no caben en el tablero
            (Bueno si caben pero si el tablero fuera mas pequeño no)
             */
            int charactersInMatrix = rnd.Next(1, m.Cols);
            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < charactersInMatrix; j++)
                {
                    
                    board[charactersArray[j].latitude, charactersArray[j].longitude] = charactersArray[j];

                }

                break;
            }

            return board;
        }

        //Metodo para imprimir tablero
        public void boardPrint(Character[,] characters)
        {
            for (int i = 0; i < characters.GetLength(0); i++)
            {
                for (int j = 0; j < characters.GetLength(1); j++)
                {
                    if (characters[i, j] != null)
                    {
                        Console.Write("[C]\t");
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
