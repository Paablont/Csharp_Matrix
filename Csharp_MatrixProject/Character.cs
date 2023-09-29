using System;
using System.Collections;
using System.Collections.Generic;
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


        //Personaje muere por porcentaje (REVISAR)
        public static Character[,] charDeath(List<Character> charactersArray, Character[,] board)
        {
            Character c = obtainCharacter(board);
            if (!(c is Neo && c is Smith))
            {
                if (c.DeathPerc > 0.7)
                {
                    board[c.Latitude, c.Longitude] = null;
                    if (board[charactersArray[0].Latitude, charactersArray[0].Longitude] == null)
                    {
                        board[charactersArray[0].Latitude, charactersArray[0].Longitude] = charactersArray[0];
                        charactersArray.RemoveAt(0);
                    }

                }
                else
                {

                    c.DeathPerc += 0.1;

                }
            }

            return board;
        }


        public static Character obtainCharacter(Character[,] board)
        {
            Character c = null;
            bool found = false;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) && !found; j++)
                {
                    if (board[i, j] != null && !board[i, j].Name.Equals("Smith") && !board[i, j].Name.Equals("Neo"))
                    {
                        
                            c = board[i, j];
                            found = true;
                            c.Latitude = i;
                            c.Longitude = j;

                        
                    }
                }
            }


            return c;

        }
        public override string? ToString()
        {
            return
                "Name: " + name;



        }
    }
}
