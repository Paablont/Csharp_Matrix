using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Csharp_MatrixProject
{
    internal class Character
    {
        private string name, cityName;
        public int latitude, longitude, age, idCharacter, characterCount = 0;
        private double deathPerc;

        public Character(string name, string cityName, int latitude, int longitude, int age, int idCharacter, double deathPerc)
        {
            this.name = name;
            this.cityName = cityName;
            this.latitude = latitude;
            this.longitude = longitude;
            this.age = age;
            this.idCharacter = idCharacter;
            this.deathPerc = deathPerc;
            characterCount++;

        }

        public Character()
        {
            characterCount++;
        }

        public string Name { get { return name; } set { name = value; } }
        public string CityName { get { return cityName; } set { cityName = value; } }
        public int Latitude { get { return latitude; } set { latitude = value; } }
        public int Longitude { get { return longitude; } set { longitude = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int IdCharacter { get { return idCharacter; } set { idCharacter = value; } }
        public double DeathPerc { get { return deathPerc; } set { deathPerc = value; } }


        //Metodo de muerte del personaje
        public static Character[,] charDeath(List<Character> charactersArray, Character[,] board)
        {
            Neo neo = Matrix.obtainNeo(board);
            Smith sm = Matrix.obtainSmith(board);
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    //Comprobamos que el objeto de esa posicion es un Character
                    if (board[i, j] != null && !(board[i, j] is Neo) && !(board[i, j] is Smith))
                    {
                        //Compruebo el porcentaje de muerte
                        if (board[i, j].DeathPerc > 0.7)
                        {

                            //Compruebo que la lista de Character no este vacia y que las posicion del Character que vaya a entrar no sean ni de neo ni de smith
                            if ((charactersArray.Count > 0) && ((charactersArray[0].Latitude != neo.Latitude && charactersArray[0].Longitude != neo.Longitude) && (charactersArray[0].Latitude != sm.Latitude && charactersArray[0].Longitude != sm.Longitude)))
                            {
                                board[i, j] = null;
                                board[charactersArray[0].Latitude, charactersArray[0].Longitude] = charactersArray[0];
                                charactersArray.RemoveAt(0);
                            }


                        }
                        else
                        {

                            board[i, j].DeathPerc += 0.1;

                        }
                    }

                }

            }
            return board;
        }       
    }
}
