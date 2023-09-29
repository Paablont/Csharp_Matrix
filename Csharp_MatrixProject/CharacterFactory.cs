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
        private const int TAMANIO_CHARACTERES = 200;
        string[] names = { "Michelle", "Alexander", "James", "Caroline", "Claire", "Jessica", "Erik", "Mike" };
        string[] cities = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };
        Character[] charactersArray = new Character[200];
        Character c;
        Matrix m = new Matrix();
        Random rnd = new Random();

        int namesInt, citiesInt, latitude, longitude, id, age;
        double deathPerc;

        public CharacterFactory()
        {
        }

        //Metodo para crear Character
        public Character charCreation()
        {
            namesInt = rnd.Next(1, names.Length);
            citiesInt = rnd.Next(1, cities.Length);
            age = rnd.Next(1, 90);
            latitude = rnd.Next(1, m.Raws);
            longitude = rnd.Next(1, m.Cols);
            id = rnd.Next(1, 200);
            deathPerc = rnd.NextDouble();

            return c = new Character(names[namesInt], cities[citiesInt], latitude, longitude, age, id, deathPerc);

        }

        //Metodo para meter en una lista los Characters para posteriormente enviarlos a la matrix(board)
        public List<Character> charInArray( NeoFactory nf, SmithFactory smf)
        {
            List<Character> charactersArray = new List<Character>();
            
            charactersArray.Add(nf.neoCreation());
            charactersArray.Add(smf.smithCreation());
            for (int i = 3; i < TAMANIO_CHARACTERES; i++)
            {
                charactersArray.Add(charCreation());
                
            }

            return charactersArray;
        }


        //Metodo para imprimir caracteres
        //public void imprimirCharacters(Character[] characters)
        //{
        //    for (int i = 0; i < characters.Length; i++)
        //    {
        //        Console.WriteLine(characters[i].Name + " " + characters[i].latitude + " " + characters[i].longitude);
        //    }
        //}

        

    }

}

