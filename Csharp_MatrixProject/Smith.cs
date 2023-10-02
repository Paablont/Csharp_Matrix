using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Smith : Character
    {
        int infecCapacity; //Sin uso en el programa

        public Smith(string name, string cityName, int latitude, int longitude, int age, int idCharacter, double deathPerc, int infecCapacity) : base(name, cityName, latitude, longitude, age, idCharacter, deathPerc)
        {
            this.infecCapacity = infecCapacity;
        }
        public Smith()
        {

        }

        public int InfectRange { get { return infecCapacity; } set { infecCapacity = value; } }

        //Metodo de movimiento de Smith
        public Character[,] smithMove(Character[,] board)
        {
            
            Character neo = Matrix.obtainNeo(board);
            Character smith = Matrix.obtainSmith(board);

            //Esto me servira para saber si Neo esta a la izq o derecha de Smith y arriba o abajo de él
            bool neoIsleft = false, neoIsUp = false;

            //Calculamoss distancia de Smith hasta Neo



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
                    //Console.WriteLine("Neo esta arriba a la izquierda");
                    board[smith.Latitude, smith.Longitude] = null;
                    smith.Latitude -= 1;
                    smith.Longitude -= 1;
                    //Si la pos de smith es igual a la de neo se vuelve donde estaba
                    if (smith.Latitude == neo.Latitude && smith.Longitude == neo.Longitude)
                    {
                        smith.Latitude += 1;
                        smith.Longitude += 1;
                        board[smith.Latitude, smith.Longitude] = smith;
                    }
                    else
                    {
                        if (board[smith.Latitude, smith.Longitude] != board[neo.Latitude, neo.Longitude])
                        {
                            board[smith.Latitude, smith.Longitude] = smith;
                        }
                    }




                }
                //Neo esta abajo a la izquierda
                if (neoIsleft && !neoIsUp)
                {
                    //Console.WriteLine("Neo esta abajo a la izquierda");
                    board[smith.Latitude, smith.Longitude] = null;
                    smith.Latitude += 1;
                    smith.Longitude -= 1;
                    if (smith.Latitude == neo.Latitude && smith.Longitude == neo.Longitude)
                    {

                        smith.Latitude -= 1;
                        smith.Longitude += 1;
                        board[smith.Latitude, smith.Longitude] = smith;
                    }
                    else
                    {
                        if (board[smith.Latitude, smith.Longitude] != board[neo.Latitude, neo.Longitude])
                        {
                            board[smith.Latitude, smith.Longitude] = smith;
                        }
                    }

                }

                //Neo esta arriba a la derecha
                if (!neoIsleft && neoIsUp)
                {
                    //Console.WriteLine("Neo esta arriba a la derecha");
                    board[smith.Latitude, smith.Longitude] = null;
                    smith.Latitude -= 1;
                    smith.Longitude += 1;
                    if (smith.Latitude == neo.Latitude && smith.Longitude == neo.Longitude)
                    {

                        smith.Latitude += 1;
                        smith.Longitude -= 1;
                        board[smith.Latitude, smith.Longitude] = smith;
                    }
                    else
                    {
                        if (board[smith.Latitude, smith.Longitude] != board[neo.Latitude, neo.Longitude])
                        {
                            board[smith.Latitude, smith.Longitude] = smith;
                        }
                    }

                }
                //Neo esta abajo a la derecha
                if (!neoIsleft && !neoIsUp)
                {
                    //Console.WriteLine("Neo esta abajo a la derecha");
                    board[smith.Latitude, smith.Longitude] = null;
                    smith.Latitude += 1;
                    smith.Longitude += 1;
                    if (smith.Latitude == neo.Latitude && smith.Longitude == neo.Longitude)
                    {

                        smith.Latitude -= 1;
                        smith.Longitude -= 1;
                        board[smith.Latitude, smith.Longitude] = smith;
                    }
                    else
                    {
                        if (board[smith.Latitude, smith.Longitude] != board[neo.Latitude, neo.Longitude])
                        {
                            board[smith.Latitude, smith.Longitude] = smith;
                        }
                    }

                }
            
            return board;
        }

        public int neoRange(Character[,] board)
        {
            Neo neo = Matrix.obtainNeo(board);
            Smith smith= Matrix.obtainSmith(board);
            int neoRange;
            neoRange = Math.Max(Math.Abs(neo.Latitude - smith.Latitude), Math.Abs(neo.Longitude - smith.Longitude));


            return neoRange;
        }

        //Metodo para generar una capacidad para infectar (sin uso)

        //public int infectHability()
        //{
        //    int infecHab;
        //    Random rnd = new Random();

        //    infecHab = rnd.Next(1, 10);

        //    return infecHab;
        //}



        //Metodo para que Smith mate a un Character  (sin uso) 

        //public Character[,] killCharacter(Character[,] board)
        //{
        //    Random rn = new Random();
        //    int infectCapacity = infectHability();
        //    Smith sm = obtainSmith(board);
        //    sm.InfectRange = infectCapacity;

        //    for (int i = 0; i < board.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < board.GetLength(1); j++)
        //        {
        //            if (board[i, j] != null)
        //            {
        //                if (board[i, j] == board[sm.Latitude, sm.Longitude] && !board[i, j].Name.Equals("Neo"))
        //                {
        //                    if (sm.InfectRange > 5)
        //                    {
        //                        Console.WriteLine("Smith ha matado a {0}", board[i, j].Name);
        //                        board[i, j] = null;
        //                    }

        //                }
        //            }
        //        }
        //    }


        //    return board;
        //}

    }
}
