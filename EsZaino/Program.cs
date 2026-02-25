using System.ComponentModel.DataAnnotations;

namespace EsZaino
{
    internal class Program
    {
        static int[] valori = { 13, 27, 11, 7, 40 };
        static int capacitàMax = 50;
        static void Main(string[] args)
        {
            
            Zaino z = new Zaino();

        }

        static void Visita(Nodo<Zaino> zaNodo)
        {
            Zaino z = zaNodo.Valore;
            if (z.NPasso >= valori.Length)
            {
                return;
            }

            if (z.ValoreAccumulato < capacitàMax)
            {
                
            }
        }
    }
}
