using System.ComponentModel.DataAnnotations;

namespace EsZaino
{
    class Program
    {
        static Zaino migliore;

        static void GeneraAlbero(int[] valori, int indice, Zaino zaino)
        {
            if (zaino.PesoAttuale > zaino.CapacitaMassima)
            {
                return;
            }

            if (indice == valori.Length)
            {
                if (zaino.PesoAttuale > 0)
                {
                    zaino.Stampa();

                    if (migliore == null || zaino.PesoAttuale > migliore.PesoAttuale ||
                        zaino.ValoriPresi.Count > migliore.ValoriPresi.Count)
                    {
                        migliore = CopiaZaino(zaino);
                    }

                }
                return;
            }

            GeneraAlbero(valori, indice + 1, CopiaZaino(zaino));

            if (zaino.PesoAttuale + valori[indice] <= zaino.CapacitaMassima)
            {
                Zaino zainoSi = CopiaZaino(zaino);
                zainoSi.ValoriPresi.Add(valori[indice]);
                zainoSi.PesoAttuale += valori[indice];
                GeneraAlbero(valori, indice + 1, zainoSi);
            }
        }

        static Zaino CopiaZaino(Zaino originale)
        {
            Zaino nuovo = new Zaino(originale.CapacitaMassima);
            nuovo.PesoAttuale = originale.PesoAttuale;
            nuovo.ValoriPresi = new List<int>(originale.ValoriPresi);
            return nuovo;
        }

        static void Main()
        {
            int[] valori = { 13, 27, 11, 7, 40 };
            int capacitàMax = 50;

            Zaino zaino = new Zaino(capacitàMax);

            Console.WriteLine("=== COMBINAZIONI VALIDE ===");
            GeneraAlbero(valori, 0, zaino);

            Console.WriteLine("\n=== MIGLIORE SOLUZIONE ===");
            migliore.Stampa();
        }
    }
}
