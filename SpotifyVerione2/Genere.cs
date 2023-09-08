using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyVerione2
{
    public class Genere
    {
        public string Nome { get; set; }
        public List<Canzone> Canzoni { get; set; }

        public Genere(string nome)
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

        public void VisualizzaCanzoni()
        {
            Console.WriteLine($"Genere: {Nome}");
            if (Canzoni.Count > 0)
            {
                foreach (var canzone in Canzoni)
                {
                    Console.WriteLine($"- {canzone.Titolo} (Artista: {canzone.Artista}, Album: {canzone.Album})");
                }
            }
            else
            {
                Console.WriteLine("Nessuna canzone in questo genere.");
            }
        }
    }
}
