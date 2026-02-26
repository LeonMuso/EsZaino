using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsZaino
{
    class Zaino
    {
        public List<int> ValoriPresi { get; set; }
        public int PesoAttuale { get; set; }
        public int CapacitaMassima { get; set; }

        public Zaino(int capacita)
        {
            ValoriPresi = new List<int>();
            PesoAttuale = 0;
            CapacitaMassima = capacita;
        }

        public void Stampa()
        {
            Console.Write("Peso: " + PesoAttuale + " | Valori: ");
            foreach (int v in ValoriPresi)
            {
                Console.Write(v + " ");
            }
            
            Console.WriteLine();
        }
    }
}
