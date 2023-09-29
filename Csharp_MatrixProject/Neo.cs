using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Character c;
            Smith smith = Smith.obtainSmith(board);
            Neo neo = obtainNeo(board);
            Random rnd = new Random();
            int newLatitude, newLongitude;
            newLatitude = rnd.Next(1, board.GetLength(0));
            newLongitude = rnd.Next(1, board.GetLength(1));

            if (board[newLatitude, newLongitude] == null)
            {
                //Vacio la posicion vieja de neo y lo relleno con la nueva
                if (smith.Latitude == neo.Latitude && smith.Longitude == neo.Longitude)
                {
                    neo.Latitude = newLatitude;
                    neo.Longitude = newLongitude;
                    board[newLatitude, newLongitude] = neo;
                }
                else
                {
                    board[neo.Latitude, neo.Longitude] = null;
                    neo.Latitude = newLatitude;
                    neo.Longitude = newLongitude;
                    board[newLatitude, newLongitude] = neo;
                }
                
                //La antigua pos de neo la dejo vacia
                

            }
            else
            {
                //Cojo el obj del personaje de la nueva pos
                c = board[newLatitude, newLongitude];
                c.Latitude = newLatitude;
                c.Longitude = newLongitude;
                board[neo.Latitude, neo.Longitude] = c;
                board[newLatitude, newLongitude] = neo;

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
        public Character[,] charNeoGenerate(List<Character> charactersArray, Character[,] board)
        {

            int charNeoGenerate = 0;

            Neo neo = obtainNeo(board);

            //Como no especifica si las diagonales, comprobaré solo arriba,abajo,izq,der

            //Comprobamos posicion arriba
            if (charNeoGenerate != 1)
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        //Comprobamos posicion arriba
                        if (board[neo.Latitude - 1, neo.Longitude] == null)
                        {
                            board[neo.Latitude - 1, neo.Longitude] = charactersArray[j];
                            charNeoGenerate = 1;
                        }
                        //Comprobamos posicion abajo
                        if (charNeoGenerate != 1)
                        {
                            if (board[neo.Latitude + 1, neo.Longitude] == null)
                            {

                                board[neo.Latitude + 1, neo.Longitude] = charactersArray[j];
                                charNeoGenerate = 1;

                            }
                        }
                        //Comprobamos posicion izquierda
                        if (charNeoGenerate != 1)
                        {
                            if (board[neo.Latitude, neo.Longitude - 1] == null)
                            {

                                board[neo.Latitude, neo.Longitude - 1] = charactersArray[j];
                                charNeoGenerate = 1;
                            }

                        }

                        //Comprobamos posicion derecha
                        if (charNeoGenerate != 1)
                        {
                            if (board[neo.Latitude, neo.Longitude + 1] == null)
                            {

                                board[neo.Latitude, neo.Longitude + 1] = charactersArray[j];
                                charNeoGenerate = 1;


                            }
                        }
                    }
                }

            }

            return board;
        }

        //Metodo para buscar a Neo
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



    }
}
