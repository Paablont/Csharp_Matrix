using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MatrixProject
{
    internal class Smith : Character
    {
        double infectRange;

        public Smith(string name, string cityName, int latitude, int longitude, int age, int idCharacter, double deathPerc, double infectRange) : base(name, cityName, latitude, longitude, age, idCharacter, deathPerc)
        {
            this.infectRange = infectRange;
        }
        public Smith()
        {

        }

        public double InfectRange { get { return infectRange; } set { infectRange = value; } }

        //Función moverse, infectar,matar
    }
}
