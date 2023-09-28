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


        //Morir
        public Character[,] charDeath(Character[] charactersArray, Character[,] board)
        {
            Character c;
            int countcharacterDeath=0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j].DeathPerc > 0.7)
                        {
                            board[i, j] = null ;
                            countcharacterDeath++;
                            board[i, j] = charactersArray[j];


                        }
                        else
                        {
                            c = board[i, j];
                            board[i, j].DeathPerc += 0.1;
                            c.DeathPerc = board[i, j].DeathPerc;
                        }

                    }
                }
            }
            Console.WriteLine("Han muerto {0} personajes", countcharacterDeath);

            return board;
        }

        public override string? ToString()
        {
            return
                "Name: " + name;



        }
    }
}
