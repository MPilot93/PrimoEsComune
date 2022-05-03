using System;

namespace EsComune

{
    public class Corriere
    {

        private readonly List<Spedizione> Carico;
        private readonly string IdCorriere;

      
        public Corriere(string nome)
        {
            IdCorriere = nome;
            Carico = new List<Spedizione>();

        }

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
            string result = string.Concat($"spedizioni affidate ad: {IdCorriere}" , Environment.NewLine);
            foreach (var item in Carico)
                result = string.Concat(result, item.GetSpedizioni() + Environment.NewLine);
            return result;
        }
    }
}

