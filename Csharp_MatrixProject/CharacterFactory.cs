﻿using System;
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
            latitude = rnd.Next(0, m.Raws);
            longitude = rnd.Next(0, m.Cols);
            id = rnd.Next(1, 200);
            deathPerc = rnd.NextDouble();

            return c = new Character(names[namesInt], cities[citiesInt], latitude, longitude, age, id, deathPerc);

        }

        //Metodo para meter en una lista los Characters para posteriormente enviarlos a la matrix(board)
        public List<Character> charInList(NeoFactory nf, SmithFactory smf)
        {
            List<Character> charactersList = new List<Character>();
            
            charactersList.Add(nf.neoCreation());
            charactersList.Add(smf.smithCreation());

            
            for (int i = 2; i < TAMANIO_CHARACTERES; i++)
            {
                c = charCreation();
                if (c.Latitude != charactersList[0].Latitude || c.Longitude != charactersList[0].Longitude)
                {
                    charactersList.Add(charCreation());
                }


            }

            return charactersList;
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

