using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class NeoFactory : CharacterFactory
    {
        Neo n;
        

        string name = "Neo";
        string[] cities = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };
        int citiesInt, latitude, longitude, id, age;
        double deathPerc;
        bool elegido;
        Random rnd = new Random();
        public Neo neoCreation()
        {
            int contadorNeo = 0, contadorSmith = 0;            
            citiesInt = rnd.Next(1, cities.Length);
            age = rnd.Next(1, 90);
            latitude = rnd.Next(1, 15);
            longitude = rnd.Next(1, 15);
            id = rnd.Next(1, 200);
            deathPerc = 0.0;
            elegido = rnd.Next(2) == 1;
            return n = new Neo(name, cities[citiesInt], latitude, longitude, age, id, deathPerc,elegido);

        }
    }
}
