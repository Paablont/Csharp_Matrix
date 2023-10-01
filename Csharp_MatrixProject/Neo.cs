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
            Smith smith = Matrix.obtainSmith(board);
            Neo neo = Matrix.obtainNeo(board);
            Random rnd = new Random();
            int newLatitude, newLongitude;
            newLatitude = rnd.Next(1, board.GetLength(0) - 1);
            newLongitude = rnd.Next(1, board.GetLength(1) - 1);

            //Compruebo que la posicion nueva donde va a ir Neo esta vacia y si no hay que hacer intercambio
            if (board[newLatitude, newLongitude] == null)
            {

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




            }

            else
            {
                //Cojo el obj del Character de la nueva pos y lo cambio con Neo
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
        public Character[,] charNeoGenerate(List<Character> charactersList, Character[,] board)
        {

            int charNeoGenerate = 0;

            Neo neo = Matrix.obtainNeo(board);

            //Como no especifica si las diagonales, comprobaré solo arriba,abajo,izq,der

            //Comprobamos posicion arriba
            if (charactersList.Count > 0 && charNeoGenerate != 1)
            {

                //Comprobamos posicion arriba
                if (board[neo.Latitude - 1, neo.Longitude] == null)
                {
                    board[neo.Latitude - 1, neo.Longitude] = charactersList[0];
                    charactersList.RemoveAt(0);
                    charNeoGenerate = 1;
                }
                //Comprobamos posicion abajo
                if (charNeoGenerate != 1)
                {
                    if (board[neo.Latitude + 1, neo.Longitude] == null)
                    {

                        board[neo.Latitude + 1, neo.Longitude] = charactersList[0];
                        charactersList.RemoveAt(0);
                        charNeoGenerate = 1;

                    }
                }
                //Comprobamos posicion izquierda
                if (charNeoGenerate != 1)
                {
                    if (board[neo.Latitude, neo.Longitude - 1] == null)
                    {

                        board[neo.Latitude, neo.Longitude - 1] = charactersList[0];
                        charactersList.RemoveAt(0);
                        charNeoGenerate = 1;
                    }

                }

                //Comprobamos posicion derecha
                if (charNeoGenerate != 1)
                {
                    if (board[neo.Latitude, neo.Longitude + 1] == null)
                    {

                        board[neo.Latitude, neo.Longitude + 1] = charactersList[0];
                        charactersList.RemoveAt(0);
                        charNeoGenerate = 1;


                    }
                }
            }

            return board;
        }





    }
}
