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

        //Creacion de personaje
        public Character charCreation()
        {
            int contadorNeo = 0, contadorSmith = 0;
            namesInt = rnd.Next(1, names.Length);
            citiesInt = rnd.Next(1, cities.Length);
            age = rnd.Next(1, 90);
            latitude = rnd.Next(1, m.Raws);
            longitude = rnd.Next(1, m.Cols);
            id = rnd.Next(1, 200);
            deathPerc = rnd.NextDouble();
            //do
            //{
            //    if (names[namesInt].Equals("Neo"))
            //    {
            //        c = new Character(names[namesInt], cities[citiesInt], latitude, longitude, age, id, deathPerc);
            //        contadorNeo = 1;
            //    }
            //    if (names[namesInt].Equals("Neo"))
            //    {
            //        c = new Character(names[namesInt], cities[citiesInt], latitude, longitude, age, id, deathPerc);
            //        contadorNeo = 1;
            //    }

            //} while (contadorNeo == 1 && contadorSmith == 1);
            
            
            return c = new Character(names[namesInt], cities[citiesInt], latitude, longitude, age, id, deathPerc);

        }

        public Character[] namesInArrays(Character[] charactersArray)
        {
            for (int i = 0; i < charactersArray.Length; i++)
            {
                charactersArray[i] = charCreation();
            }

            return charactersArray;
        }

        


        //Metodo para imprimir caracteres
        public void imprimirCharacters(Character[] characters)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine(characters[i].Name +" "+ characters[i].latitude + " " + characters[i].longitude);
            }
        }

    }

}

