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

        //Función moverse, infectar,matar
        public int infectHability()
        {
            int infecHab;
            Random rnd = new Random();

            infecHab = rnd.Next(1, 10);

            return infecHab;


        }

        public Character[,] killCharacter(Character[,] board, int infecHab)
        {
            if (infecHab > 5)
            {
                //mata al personaje que pille
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {

                    }
                }
            }//No mata

            return board;
        }

        public Character[,] smithMove(Character[,] board)
        {
            int neoRange;
            Character neo = null, smith = null;
            bool neoIsleft = false, neoIsUp = false; //Esto me servira para saber si Neo esta a la izq o derecha de Smith y arriba o abajo de él
            //Calcular las casillas hasta neo(primero ver donde esta neo)
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].name.Equals("Neo"))
                        {

                            neo = board[i, j];

                        }
                        if (board[i, j].name.Equals("Smith"))
                        {

                            smith = board[i, j];

                        }

                    }
                }


            }

            if (neo != null && smith != null)
            {
                //Calculamos distancia
                neoRange = Math.Max(Math.Abs(neo.Latitude - smith.Latitude), Math.Abs(neo.Longitude - smith.Longitude));

            }
            //Vemos si neo esta a la derecha o izquierda de smith y arriba o abajo
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
                        if (board[i, j].name.Equals("Smith"))
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
    }
}
