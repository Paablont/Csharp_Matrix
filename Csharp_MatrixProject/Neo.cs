using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Neo : Character
    {
        bool elegido;
        public Neo(string name, string cityName, int latitude, int longitude, int age, int idCharacter, double deathPerc, bool elegido) : base(name, cityName, latitude, longitude, age, idCharacter, deathPerc)
        {
            this.elegido = elegido;
        }

        public Neo()
        {

        }

        public bool Elegido { get { return elegido; } set { elegido = value; } }

        //Función mover Neo
        public Character[,] neoMove(Character[,] board)
        {
            Character c, neo;
            Random rnd = new Random();
            int newLatitude, newLongitude;
            newLatitude = rnd.Next(1, board.GetLength(0));
            newLongitude = rnd.Next(1, board.GetLength(1));

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].name.Equals("Neo"))
                        {

                            if (board[newLatitude, newLongitude] == null)
                            {
                                //Cojo el objeto de neo y lo llevo a la nueva pos
                                neo = board[i, j];
                                board[newLatitude, newLongitude] = neo;
                                //La antigua pos de neo la dejo vacia
                                board[i, j] = null;

                            }
                            else
                            {
                                //Cojo el obj del personaje de la nueva pos
                                c = board[newLatitude, newLongitude];
                                neo = board[i, j];
                                board[i, j] = c;
                                board[newLatitude, newLongitude] = neo;

                            }
                        }


                    }

                }
            }
            return board;
        }

        //Funcion es elegido o no
        public bool theChosenOne()
        {
            bool choseOne = false;
            Random rnd = new Random();

            double chosenPercent = rnd.NextDouble();

            if (chosenPercent > 0.5)
            {
                choseOne = true;
            }


            return choseOne;


        }
        //Funcion generar personaje adyadcente 
        public Character[,] charNeoGenerate(Character[] charactersArray, Character[,] board)
        {
            int latNeo, longNeo;
            int charNeoGenerate = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].name.Equals("Neo"))
                        {
                            latNeo = i;
                            longNeo = j;
                            //Como no especifica si las diagonales, comprobaré solo arriba,abajo,izq,der

                            //Comprobamos posicion arriba
                            if (charNeoGenerate != 1)
                            {
                                
                                
                                if (board[latNeo - 1, longNeo] == null)
                                {
                                    board[latNeo - 1, longNeo] = charactersArray[j];
                                    charNeoGenerate = 1;
                                }
                            }
                            //Comprobamos posicion abajo
                            if (charNeoGenerate != 1 )
                            {
                                if (board[latNeo + 1, longNeo] == null)
                                {

                                    board[latNeo + 1, longNeo] = charactersArray[j];
                                    charNeoGenerate = 1;

                                }
                            }
                            //Comprobamos posicion izquierda
                            if (charNeoGenerate != 1)
                            {
                                if (board[latNeo, longNeo - 1] == null)
                                {

                                    board[latNeo, longNeo - 1] = charactersArray[j];
                                    charNeoGenerate = 1;
                                }

                            }

                            //Comprobamos posicion derecha
                            if (charNeoGenerate != 1)
                            {
                                if (board[latNeo, longNeo + 1] == null)
                                {

                                    board[latNeo, longNeo + 1] = charactersArray[j];
                                    charNeoGenerate = 1;


                                }
                            }
                        }
                    }
                }
            }



            return board;
        }



    }
}
