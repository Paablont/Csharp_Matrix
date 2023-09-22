using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Character
    {
        private string name { get; set; }
        private string cityName { get; set; }
        private int latitude { get; set; }
        private int longitude { get; set; }
        private int age { get; set; }
        private int idCharacter { get; set; }
        private double deathPerc { get; set; }
        private static int characterCount { get; set; }

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
    }
}
