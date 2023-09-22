using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Character
    {
        public string name {get; set; }
        public string cityName { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public int age { get; set; }
        public int idCharacter { get; set; }
        public double deathPerc { get; set; }
        public static int characterCount { get; set; }

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

        public override string? ToString()
        {
            return "ID: " + idCharacter + "\n" +
                "Name: " + name + "\n" +
                "Age: " + age + "\n" +
                "City name: " + cityName + "\n" +
                "Latitude: " + latitude + "\n" +
                "Longitude: " + longitude + "\n" +
                "Death Percentaje : " + Math.Round(deathPerc,2);
                
                
                
        }
    }
}
