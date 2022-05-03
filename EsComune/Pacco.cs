using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsComune
{
    public class Pacco : Spedizione
    {
        //proprietà
        private readonly double Altezza;
        private readonly double Lunghezza;
        private readonly double Profondita;
        //costruttore
        public Pacco (string mittente, string destinatario, decimal valore, double altezza, double lunghezza, double profondita ) 
            : base(mittente, destinatario, valore) 
        {
            Altezza=altezza;
            Lunghezza=lunghezza;
            Profondita=profondita;
        }
      //implemento metodo
        public override double printIngombro() => Altezza * Lunghezza * Profondita;
      
    }
}
