# Lista de Peliculas

namespace Pelicula2
{
    class Pelicula2
    {
        private string Titulo;
        public Pelicula2(string T)
        {
            Titulo = T;
        }
        public void imprime()
        {
            Console.WriteLine(Titulo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula2> Pelis= new List<Pelicula2>();
            Pelis.Add(new Pelicula2("Joker"));
            Pelis.Add(new Pelicula2("La forma de agua"));
            Pelis.Add(new Pelicula2("Parasito"));
            Pelis.Add(new Pelicula2("El renacido"));
            Pelis.Add(new Pelicula2("Messi"));

            foreach (Pelicula2 a in Pelis)
            {
                a.imprime();
            }
        }
    }
}