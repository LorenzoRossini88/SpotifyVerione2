using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyVerione2
{
    public class Canzone
    {
        public string Titolo { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public double Durata { get; set; } 

        public Canzone(string titolo, string artista, string album, double durata)
        {
            Titolo = titolo;
            Artista = artista;
            Album = album;
            Durata = durata;
        }

        public void VisualizzaDettagliCanzone()
        {
            Console.WriteLine($"Titolo Canzone: {Titolo}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Durata: {Durata} secondi");
        }
    }
}
