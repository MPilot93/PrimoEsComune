using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsComune.Mylibrary
{
    public class Corriere
    {
        public string Nome { get; }
        public List<Spedizione> CorrList;

        public Corriere(string nomeCorriere)
        {
            CorrList = new List<Spedizione>();
            NomeCorriere = nomeCorriere;
        }

        public void PrintSpedizioni()
        {
            double ingombroTot = 0;
            Console.WriteLine("\n---------- Riepilogo Spedizioni ----------\n");
            foreach (var s in CorrList)
            {
                Console.WriteLine($"Mittente: {s.Mittente}\n" +
                    $"Destinatario: {s.Destinatario}\n" +
                    $"Ingombro: {s.getIngombro()}\n" +
                    $"-----------------------------");
                ingombroTot += s.getIngombro();
            }

            Console.WriteLine($"Ingombro TOT: {ingombroTot}");
        }

        public bool addSpedizione(Spedizione s)
        {
            if (!CorrList.Contains(s))
            {
                CorrList.Add(s);
                return true;
            }
            return true;
        }
    }
}