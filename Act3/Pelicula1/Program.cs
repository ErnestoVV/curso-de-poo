using System;

namespace Pelicula1
{
    public class Pelicula1
    {
	    private string Titulo;
	    private string Pais;
	    private string Director;
        private int Año;
	    public void SetTitulo(string T)
        {
		    Titulo = T;	
        
	    }
	    public string GetTitulo()
        {
	        return Titulo;	
	    }
        public void SetPais(string P)
        {
		    Pais = P;	
        
	    }
	    public string GetPais()
        {
	        return Pais;	
	    }
        public void SetDirector(string D)
        {
		    Director = D;	
	    }
	    public string GetDirector()
        {
	        return Director;	
	    }
	    public void SetAño(int A)
        {
		    Año = A;	
	    }
	    public int GetAño()
        {
		    return Año;	
	    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula1 P1 = new Pelicula1();
		    P1.SetTitulo("Joker");
            P1.SetPais("Estados Unidos");
            P1.SetDirector("Todd Phillips");
		    P1.SetAño(2019);
		    Pelicula1 P2 = new Pelicula1();
		    P2.SetTitulo("La forma de agua");
            P2.SetPais("Estados Unidos");
            P2.SetDirector("Gullermo del toro");
		    P2.SetAño(2018);
            Console.WriteLine("Titulo:" + P1.GetTitulo() + " Pais:" + P1.GetPais() + " Director:" + P1.GetDirector() + " Año:" + P1.GetAño());
            Console.WriteLine("Titulo:" + P2.GetTitulo() + " Pais:" + P2.GetPais() + " Director:" + P2.GetDirector() + " Año:" + P2.GetAño());
        }
    }
}
