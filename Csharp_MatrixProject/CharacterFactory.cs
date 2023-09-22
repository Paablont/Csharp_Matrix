using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class CharacterFactory
    {
        string[] names = { "Michelle", "Alexander", "James", "Caroline","Claire", "Jessica", "Erik", "Mike"};

        string[] cities = {"Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas" , "Denver" };


        Character c;
        Matrix m = new Matrix();
        Random rnd = new Random();
        int namesInt, citiesInt,latitude,longitude,id,age;
        double deathPerc;

        public CharacterFactory()
        {
        }

        public Character charCreation()
        {
            namesInt = rnd.Next(1,names.Length);
            citiesInt = rnd.Next(1,cities.Length);
            age = rnd.Next(1, 90);
            latitude = rnd.Next(1, m.Raws);
            longitude = rnd.Next(1, m.Cols);
            id = rnd.Next(1, 200);
            deathPerc = rnd.NextDouble();


            c = new Character(names[namesInt], cities[citiesInt] ,latitude,longitude,age,id,deathPerc);

            return c;
        }


    }
}
