using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsComune
{
    public class Plico : Spedizione
    {
        //proprietà
        private readonly double Altezza;
        private readonly double Lunghezza;

        //costruttore
        public Plico(string mittente, string destinatario, decimal valore, double altezza, double lunghezza)
            : base(mittente, destinatario, valore)
        {
            Altezza = altezza;
            Lunghezza = lunghezza;
        }

        // implemento metodo
        public override double printIngombro() => Altezza * Lunghezza;
    
    }
}
