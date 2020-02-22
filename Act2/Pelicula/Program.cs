using System;
using System.Collections.Generic;

namespace Pelicula
{
    public class Pelicula
        {
            public string Titulo, Pais, Director;
            public int Año;
        }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula peli1 = new Pelicula(); 
            peli1.Titulo = "Joker";
            peli1.Pais = "Estados Unidos";
            peli1.Director = "Todd Phillips";
            peli1.Año = 2019;

            Pelicula peli2 = new Pelicula(); 
            peli2.Titulo = "La forma de agua";
            peli2.Pais = "Estados Unidos";
            peli2.Director = "Guillermo Del Toro";
            peli2.Año = 2018;
            
            Console.WriteLine("Titulo:{0}, Pais:{1}, Director:{2}, Año:{3}",peli1.Titulo, peli1.Pais, peli1.Director, peli1.Año );
            Console.WriteLine("Titulo:{0}, Pais:{1}, Director:{2}, Año:{3}",peli2.Titulo, peli2.Pais, peli2.Director, peli2.Año );

        }
    }
}
