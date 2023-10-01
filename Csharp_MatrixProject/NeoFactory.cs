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
        Matrix m = new Matrix();

        string name = "Neo";
        string[] cities = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };
        int citiesInt, latitude, longitude, id, age;
        double deathPerc;
        bool elegido;
        Random rnd = new Random();

        //Metodo para crear a Neo
        public Neo neoCreation()
        {
            int contadorNeo = 0, contadorSmith = 0;
            citiesInt = rnd.Next(1, cities.Length);
            age = rnd.Next(1, 90);
            latitude = rnd.Next(1, m.Raws - 1);
            longitude = rnd.Next(1, m.Cols - 1);
            id = rnd.Next(1, 200);
            elegido = rnd.Next(2) == 1;
            return n = new Neo(name, cities[citiesInt], latitude, longitude, age, id, deathPerc, elegido);

        }
    }
}
