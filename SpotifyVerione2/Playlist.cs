using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyVerione2
{
    public class Playlist
    {
        public string Nome { get; set; }
        public List<Canzone> Canzoni { get; set; }

        public Playlist(string nome)
        {
            Nome = nome;
            Canzoni = new List<Canzone>();
        }

        public void AggiungiCanzone(Canzone canzone)
        {
            Canzoni.Add(canzone);
        }

        public void RimuoviCanzone(Canzone canzone)
        {
            Canzoni.Remove(canzone);
        }

        public void VisualizzaDettagliPlaylist()
        {
            Console.WriteLine($"Nome Playlist: {Nome}");
            Console.WriteLine("Canzoni nella playlist:");
            foreach (var canzone in Canzoni)
            {
                Console.WriteLine($"- {canzone.Titolo} (Artista: {canzone.Artista}, Album: {canzone.Album})");
            }
        }

        static void GestisciPlaylist(Playlist playlist)
        {
            Console.WriteLine("Sezione Playlist");
            Console.WriteLine("1 - Visualizza playlist");
            Console.WriteLine("2 - Aggiungi canzone alla playlist");
            int sceltaPlaylist = int.Parse(Console.ReadLine());

            switch (sceltaPlaylist)
            {
                case 1:
                    playlist.VisualizzaDettagliPlaylist();
                    break;
                case 2:
                    Console.WriteLine("Inserisci il titolo della canzone da aggiungere:");
                    string titoloCanzone = Console.ReadLine();
                    // Implementa la logica per aggiungere la canzone alla playlist
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}
