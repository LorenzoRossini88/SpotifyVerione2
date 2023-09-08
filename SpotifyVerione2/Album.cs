using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyVerione2
{
    public class Album
    {
        public string Titolo { get; set; }
        public int AnnoPubblicazione { get; set; }
        public List<Canzone> Canzoni { get; set; }

        public Album(string titolo, int annoPubblicazione)
        {
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Canzoni = new List<Canzone>();
        }

        public void AggiungiCanzone(Canzone canzone)
        {
            Canzoni.Add(canzone);
        }

        public void VisualizzaDettagliAlbum()
        {
            Console.WriteLine($"Titolo Album: {Titolo}");
            Console.WriteLine($"Anno di Pubblicazione: {AnnoPubblicazione}");
            Console.WriteLine("Canzoni:");
            foreach (var canzone in Canzoni)
            {
                Console.WriteLine($"- {canzone.Titolo}");
            }
        }
    }
}
