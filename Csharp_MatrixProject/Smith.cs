using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Smith : Character
    {
        int infectRange;

        public Smith(string name, string cityName, int latitude, int longitude, int age, int idCharacter, double deathPerc, int infectRange) : base(name, cityName, latitude, longitude, age, idCharacter, deathPerc)
        {
            this.infectRange = infectRange;
        }
        public Smith()
        {

        }

        public int InfectRange { get { return infectRange; } set { infectRange = value; } }

        //Generar capacidad de infectar
        public int infectHability()
        {
            int infecHab;
            Random rnd = new Random();

            infecHab = rnd.Next(1, 10);

            return infecHab;


        }

        //Matar a un personaje (POR HACER)
        public Character[,] killCharacter(Character[,] board)
        {

            //mata al personaje que pille
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (infectHability() > 5)
                        {
                            board[i, j] = null;
                        }
                    }
                }
            }


            return board;
        }

        //Movimiento smith
        public Character[,] smithMove(Character[,] board)
        {
            int neoRange;
            Character neo = Neo.obtainNeo(board);
            Character smith = obtainSmith(board);
            //Esto me servira para saber si Neo esta a la izq o derecha de Smith y arriba o abajo de él
            bool neoIsleft = false, neoIsUp = false;
            //Calculamoss distancia
            neoRange = Math.Max(Math.Abs(neo.Latitude - smith.Latitude), Math.Abs(neo.Longitude - smith.Longitude));

            //Vemos si neo esta a la arriba o abaj  y derecha o izq
            if (neo.Latitude < smith.Latitude)
            {
                neoIsUp = true;
                if (neo.Longitude < smith.Longitude)
                {
                    neoIsleft = true;
                }

            }
            //Movemos a smith
            Random rnd = new Random();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j] is Smith)
                        {
                            //Neo esta arriba a la izquierda
                            if (neoIsleft && neoIsUp)
                            {
                                smith.Latitude -= 1;
                                smith.Longitude -= 1;
                                board[smith.Latitude, smith.Longitude] = smith;
                                board[i, j] = null;
                            }
                            //Neo esta abajo a la izquierda

                            if (neoIsleft && !neoIsUp)
                            {
                                smith.Latitude += 1;
                                smith.Longitude -= 1;
                                board[smith.Latitude, smith.Longitude] = smith;
                                board[i, j] = null;
                            }
                            //Neo esta arriba a la derecha
                            if (!neoIsleft && neoIsUp)
                            {
                                smith.Latitude -= 1;
                                smith.Longitude += 1;
                                board[smith.Latitude, smith.Longitude] = smith;
                                board[i, j] = null;
                            }
                            //Neo esta abajo a la derecha
                            if (!neoIsleft && !neoIsUp)
                            {
                                smith.Latitude += 1;
                                smith.Longitude += 1;
                                board[smith.Latitude, smith.Longitude] = smith;
                                board[i, j] = null;
                            }
                        }


                    }

                }
            }
            return board;
        }

        //Metodo para buscar a smith en board
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
                        if (board[i, j] is Smith)
                        {
                            sm = (Smith)board[i, j];
                            found = true;

                        }
                    }
                }
            }
            return sm;
        }
    }
}
