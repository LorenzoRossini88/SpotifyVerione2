using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyVerione2
{
    public class Artista
    {
        public string Nome { get; set; }
        public DateTime DataNascita { get; set; }
        public List<Album> Album { get; set; }

        public Artista(string nome, DateTime dataNascita)
        {
            Nome = nome;
            DataNascita = dataNascita;
            Album = new List<Album>();
        }

        public void AggiungiAlbum(Album album)
        {
            Album.Add(album);
        }

        public void VisualizzaDettagliArtista()
        {
            Console.WriteLine($"Nome Artista: {Nome}");
            Console.WriteLine($"Data di Nascita: {DataNascita.ToShortDateString()}");
            Console.WriteLine("Album:");
            foreach (var album in Album)
            {
                Console.WriteLine($"- {album.Titolo}");
            }
        }


        static void GestisciArtisti(Artista artista1, Artista artista2)
        {
            Console.WriteLine("Sezione Artisti");
            Console.WriteLine("1 - Visualizza lista artisti");
            Console.WriteLine("2 - Visualizza album e canzoni di un artista");
            int sceltaArtista = int.Parse(Console.ReadLine());

            switch (sceltaArtista)
            {
                case 1:
                    Console.WriteLine("Lista degli artisti:");
                    Console.WriteLine($"1. {artista1.Nome}");
                    Console.WriteLine($"2. {artista2.Nome}");
                    break;
                case 2:
                    Console.WriteLine("Seleziona un artista:");
                    int sceltaArtistaSpecifico = int.Parse(Console.ReadLine());
                    if (sceltaArtistaSpecifico == 1)
                    {
                        artista1.VisualizzaDettagliArtista();
                    }
                    else if (sceltaArtistaSpecifico == 2)
                    {
                        artista2.VisualizzaDettagliArtista();
                    }
                    else
                    {
                        Console.WriteLine("Artista non valido.");
                    }
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }


        }

    }
}
