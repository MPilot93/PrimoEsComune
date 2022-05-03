using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsComune

{
    public class Corriere
    {
        //proprietà
        private readonly List<Spedizione> Carico;
        private string IdCorriere;

        //costruttore
        public Corriere(string nome)
        {
            IdCorriere = nome;
            Carico = new List<Spedizione>();

        }

        //metodi classe
        public void AddSpedizione(Spedizione spedizione) 
        { 
            Carico.Add(spedizione); 
        }

        public double GetTotalIngombro()
        {
            double result = 0;
            foreach (var item in Carico)
                result += item.printIngombro();
            return result;
        }

        public string GetSpedizioni()
        {
            string result = $"spedizioni affidate ad: {IdCorriere}" +"\n";
            foreach (var item in Carico)
                result = string.Concat(result, item.GetSpedizioni() +"\n");
            return result;
        }
    }
}

