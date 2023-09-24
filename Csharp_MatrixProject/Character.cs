using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Character
    {
        public string name, cityName;
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

        public  string Name { get { return name; } set { name = value; } }
        public string CityName { get { return cityName; } set {  cityName = value; } }
        public int Latitude { get { return latitude;} set { latitude = value; } }
        public int Longitude { get { return longitude;} set { longitude = value; } }
        public int Age { get { return age;} set { age = value; } }
        public int IdCharacter { get { return idCharacter; } set { idCharacter = value; } }
        public double DeathPerc { get {  return deathPerc; } set {  deathPerc = value; } }
        


        public Character[] charDeath(Character[] character)
        {
            Character[] result;
            int charactersDeath = 0;
            int charactersAlive = 0;
            for (int i = 0; i < character.Length; i++)
            {
                if (character[i].deathPerc > 0.7)
                {
                    Console.WriteLine("El personaje ha muerto");
                    charactersDeath++;
                }
                else
                {
                    character[i].deathPerc = character[i].deathPerc * 0.1;
                }
            }

            charactersAlive = character.Length - charactersDeath;
            result = new Character[charactersAlive];

            //Ahora creo una nueva matriz con los que quedan vivos
            int newIndent = 0;
            for (int i = 0; i < character.Length; i++)
            {
                if (character[i].deathPerc <= 0.7)
                {
                    result[newIndent] = character[i];
                    newIndent++;
                }
            }

            return result;

        }

        public override string? ToString()
        {
            return
                "Name: " + name;
                
                
                
        }
    }
}
