using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsComune

{
    public class Corriere
    {

        private readonly List<Spedizione> Carico;
        private string Nome;
        public Corriere(string nome)
        {
            Nome = nome;
            Carico = new List<Spedizione>();

        }
        public void AddSpedizione(Spedizione spedizione) { Carico.Add(spedizione); }

        public double GetTotalIngombro()
        {
            double result = 0;
            foreach (var item in Carico)
                result += item.printIngombro();
            return result;
        }

        public string GetSpedizioni()
        {
            string result = $"spedizioni affidate ad: {Nome}";
            foreach (var item in Carico)
                result = string.Concat(result, item.GetSpedizioni());
            return result;
        }
    }
}

