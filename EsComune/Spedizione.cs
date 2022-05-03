namespace EsComune
{
    public abstract class Spedizione
    {
        protected string Mittente;
        protected string Destinatario;
        protected decimal Valore;

        protected Spedizione (string mit, string des, decimal val)
        {
            Mittente = mit;
            Destinatario = des;
            Valore = val;
        }

        public abstract double printIngombro();

        public  bool Equal(Spedizione other)
        {
            return other.Mittente==Mittente
                && other.Destinatario==Destinatario
                && other.Valore==Valore
                && other.printIngombro()==printIngombro();
        }

        public string GetSpedizioni()
        {
            return $"Mittente: {Mittente} / Destinatario: {Destinatario} / Valore: {Valore} / Ingombro totale: {printIngombro()}";
        }
    }
}