using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyVerione2
{
    public class Player
    {
        private List<Canzone> codaDiRiproduzione = new List<Canzone>();
        private int indiceRiproduzione = 0;
        private bool inPausa = false;

        public void AggiungiAllaCoda(Canzone canzone)
        {
            codaDiRiproduzione.Add(canzone);
            Console.WriteLine($"Aggiunta '{canzone.Titolo}' alla coda di riproduzione.");
        }

        public void Riproduci()
        {
            if (codaDiRiproduzione.Count == 0)
            {
                Console.WriteLine("Nessuna canzone nella coda di riproduzione.");
                return;
            }

            if (inPausa)
            {
                Console.WriteLine($"Ripresa riproduzione di '{codaDiRiproduzione[indiceRiproduzione].Titolo}'.");
                inPausa = false;
            }
            else
            {
                Console.WriteLine($"Riproduzione di '{codaDiRiproduzione[indiceRiproduzione].Titolo}'.");
            }
        }

        public void Pausa()
        {
            if (inPausa)
            {
                Console.WriteLine("La riproduzione è già in pausa.");
            }
            else
            {
                Console.WriteLine($"Pausa di '{codaDiRiproduzione[indiceRiproduzione].Titolo}'.");
                inPausa = true;
            }
        }

        public void Avanti()
        {
            if (codaDiRiproduzione.Count == 0)
            {
                Console.WriteLine("Nessuna canzone nella coda di riproduzione.");
                return;
            }

            if (indiceRiproduzione < codaDiRiproduzione.Count - 1)
            {
                indiceRiproduzione++;
            }
            else
            {
                
                indiceRiproduzione = 0;
            }

            Console.WriteLine($"Passaggio a '{codaDiRiproduzione[indiceRiproduzione].Titolo}'.");
        }

        public void Indietro()
        {
            if (codaDiRiproduzione.Count == 0)
            {
                Console.WriteLine("Nessuna canzone nella coda di riproduzione.");
                return;
            }

            if (indiceRiproduzione > 0)
            {
                indiceRiproduzione--;
            }
            else
            {
                
                indiceRiproduzione = codaDiRiproduzione.Count - 1;
            }

            Console.WriteLine($"Tornando a '{codaDiRiproduzione[indiceRiproduzione].Titolo}'.");
        }
    }
}
