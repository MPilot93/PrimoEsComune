
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace EsComune.Mylibrary
    {
        public class Pacco : SpedizioneAstratta
        {

            public double Altezza { get; set; }
            public double Larghezza { get; set; }
            public double Profondita { get; set; }

            public Pacco(string mittente, string destinatario) : base(mittente, destinatario)
            {
            }

            public override double getIngombro()
            {
                return Larghezza * Altezza * Profondita;
            }
        }
    }