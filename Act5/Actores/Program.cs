using System;
using System.Collections.Generic;
 
namespace Actores
{
    class Actores
    {
        private string Nombre;
        public Actores(string N)
        {
            Nombre = N;
        }
        public void imprime()
        {
            Console.WriteLine(Nombre);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Actores> Actor = new List<Actores>();
            Actor.Add(new Actores("Leonardo Dicaprio"));
            Actor.Add(new Actores("Johnny Depp"));
            Actor.Add(new Actores("Vin Diesel"));
            Actor.Add(new Actores("Will Smith"));
 
            foreach(Actores a in Actor)
            {
                a.imprime();
            }
            
        }
    }
}
