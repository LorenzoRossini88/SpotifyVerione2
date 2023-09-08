using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Text;
//using CsvHelper;
//using CsvHelper.Configuration;

namespace SpotifyVerione2
{
    internal class Program
    {
        static void Main(string[] args)
        {




            List<Canzone> list = new List<Canzone>();
            list.Add(new Canzone("Destinazione mare", "Tiziano Ferro", "ciao", 2.13));
            list.Add(new Canzone("A", "Tiziano Ferro", "ciao", 2.13));
            list.Add(new Canzone("Destinazione mare", "Tiziano Ferro", "ciao", 2.13));
            list.Add(new Canzone("Destinazione mare", "Tiziano Ferro", "ciao", 2.13));

            //list.Add(new() { Name = "Marco", Age = 30 });
            //list.Add(new() { Name = "Diego", Age = 20 });
            //list.Add(new() { Name = "Mauro", Age = 10 });


            saveToFile(list, @"C:\logs\fileConfiguration.csv");
            var result = LoadFromTextFileCsvHelper<Canzone>(@"C:\logs\fileConfiguration.csv");

            foreach (var p in result.ToList())
            {
                Console.Write($" Titolo: {p.Titolo}");
                Console.Write($" -  ");
                Console.Write($"Autore: {p.Artista}");
                Console.WriteLine($"  ");
                Console.Write($"Album: {p.Album}");
                Console.WriteLine($"  ");
                Console.Write($"Durata: {p.Durata}");
                Console.WriteLine($"  ");

            }






            Player player = new Player();



            while (true)
            {
                Console.WriteLine("Benvenuto in Spotify Replica!");
                Console.WriteLine("Scegli una sezione:");
                Console.WriteLine("P - Profilo");
                Console.WriteLine("A - Artisti");
                Console.WriteLine("L - Playlist");
                Console.WriteLine("G - Generi");
                Console.WriteLine("S - Cerca");
                Console.WriteLine("Q - Esci");

                string scelta = Console.ReadLine();

                switch (scelta.ToUpper())
                {
                    case "P":
                        // Gestisci il profilo (volume, impostazioni utente, ecc.)
                        break;
                    case "A":
                        // Gestisci gli artisti (lista artisti, album, canzoni)
                        break;
                    case "L":
                        // Gestisci la playlist (visualizza, crea, modifica playlist)
                        break;
                    case "G":
                        // Gestisci i generi (canzoni divise per genere)
                        break;
                    case "S":
                        // Gestisci la ricerca (cerca canzoni e album)
                        break;
                    case "Q":
                        Console.WriteLine("Chiusura in corso...");
                        return;
                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }


            }







        }

        public static void saveToFile<T>(List<T> data, string filePath) where T : class
        {
            List<string> lines = new List<string>(); // 
            StringBuilder line = new StringBuilder();

            if (data == null || data.Count == 0)
            {
                throw new ArgumentException("data", "La lista è vuota!");
            }

            var cols = data[0].GetType().GetProperties();

            foreach (var col in cols)// cicla tutte le Entity della classe in oggetto
            {
                line.Append(col.Name);
                line.Append(",");
            }

            lines.Add(line.ToString().Substring(0, line.Length - 1));

            foreach (var row in data)
            {

                line = new StringBuilder();
                foreach (var col in cols)// cicla tutte le Entity della classe in oggetto
                {
                    line.Append(col.GetValue(row));
                    line.Append(",");
                }
                lines.Add(line.ToString().Substring(0, line.Length - 1));
            }

            System.IO.File.WriteAllLines(filePath, lines);


        }

        public static List<T> LoadFromTextFileCsvHelper<T>(string filePath) where T : class, new()
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8, // Our file uses UTF-8 encoding.
                Delimiter = "," // The delimiter is a comma.
            };
            List<T> records;

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                records = csv.GetRecords<T>().ToList();
            }

            return records;
        }

    }


}
