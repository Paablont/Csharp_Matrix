using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Smith : Character
    {
        int infecCapacity;

        public Smith(string name, string cityName, int latitude, int longitude, int age, int idCharacter, double deathPerc, int infecCapacity) : base(name, cityName, latitude, longitude, age, idCharacter, deathPerc)
        {
            this.infecCapacity = infecCapacity;
        }
        public Smith()
        {

        }

        public int InfectRange { get { return infecCapacity; } set { infecCapacity = value; } }

        //Generar capacidad de infectar
        public int infectHability()
        {
            int infecHab;
            Random rnd = new Random();

            infecHab = rnd.Next(1, 10);

            return infecHab;


        }

        //Matar a un personaje  (REVISAR)
        public Character[,] killCharacter(Character[,] board)
        {
            Random rn = new Random();
            int infectCapacity = infectHability();
            Smith sm = obtainSmith(board);
            sm.InfectRange = infectCapacity;

            for (int i = 0;i<board.GetLength(0);i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i,j] != null)
                    {
                        if (board[i,j] == board[sm.Latitude, sm.Longitude])
                        {
                            if(sm.InfectRange > 5)
                            {
                                Console.WriteLine("Smith ha matado a {0}", board[i, j].Name);
                                board[i, j] = null;
                            }
                            
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
            if (smith.Latitude >= neo.Latitude)
            {
                neoIsUp = true;
                

            }
            if (smith.Longitude >= neo.Longitude)
            {
                neoIsleft = true;
            }

            //Movemos a smith
            Random rnd = new Random();

            //Neo esta arriba a la izquierda
            if (neoIsleft && neoIsUp)
            {
                Console.WriteLine("Neo esta arriba a la izquierda");
                board[smith.Latitude, smith.Longitude] = null;
                smith.Latitude -= 1;
                smith.Longitude -= 1;
                board[smith.Latitude, smith.Longitude] = smith;

            }
            //Neo esta abajo a la izquierda

            if (neoIsleft && !neoIsUp)
            {
                Console.WriteLine("Neo esta abajo a la izquierda");
                board[smith.Latitude, smith.Longitude] = null;
                smith.Latitude += 1;
                smith.Longitude -= 1;
                board[smith.Latitude, smith.Longitude] = smith;

            }
            //Neo esta arriba a la derecha
            if (!neoIsleft && neoIsUp)
            {
                Console.WriteLine("Neo esta arriba a la derecha");
                board[smith.Latitude, smith.Longitude] = null;
                smith.Latitude -= 1;
                smith.Longitude += 1;
                board[smith.Latitude, smith.Longitude] = smith;

            }
            //Neo esta abajo a la derecha
            if (!neoIsleft && !neoIsUp)
            {
                Console.WriteLine("Neo esta abajo a la derecha");
                board[smith.Latitude, smith.Longitude] = null;
                smith.Latitude += 1;
                smith.Longitude += 1;
                board[smith.Latitude, smith.Longitude] = smith;

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
                        if (board[i, j].Name.Equals("Smith"))
                        {
                            sm = (Smith)board[i, j];
                            found = true;
                            sm.Latitude = i;
                            sm.Longitude = j;

                        }
                    }
                }
            }
            return sm;
        }
    }
}
