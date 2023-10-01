using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class SmithFactory
    {
        Smith n;
        string name = "Smith";
        string[] cities = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };
        int citiesInt, latitude, longitude, id, age;
        double deathPerc;
        int infectRange;
        Random rnd = new Random();
        public Smith smithCreation()
        {

            citiesInt = rnd.Next(1, cities.Length);
            age = rnd.Next(1, 90);
            latitude = rnd.Next(1, 14);
            longitude = rnd.Next(1, 14);
            id = rnd.Next(1, 200);
            infectRange = rnd.Next(1, 10);
            return n = new Smith(name, cities[citiesInt], latitude, longitude, age, id, deathPerc, infectRange);

        }


    }
}
