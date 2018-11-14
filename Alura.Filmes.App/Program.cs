using Alura.Filmes.App.Dados;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                foreach (var item in contexto.Atores)
                {
                    System.Console.WriteLine(item);

                }
                System.Console.ReadKey();
            }
        }
    }
}