# Profe este peor a los anteriores no se porque me pasa esto pero si revisa en la carpeta de ACt2/Pelicula2 esta el archivo program.cs y sale bien :/

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