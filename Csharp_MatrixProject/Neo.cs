using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Neo : Character
    {
        bool elegido;
        public Neo(string name, string cityName, int latitude, int longitude, int age, int idCharacter, double deathPerc,bool elegido) : base(name, cityName, latitude, longitude, age, idCharacter, deathPerc)
        {
            this.elegido = elegido;
        }


    }
}
