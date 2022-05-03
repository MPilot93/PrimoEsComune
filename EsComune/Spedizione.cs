namespace EsComune
{
    public abstract class Spedizione
    {
        //Proprietà classe astratta
        protected string mittente;
        protected string destinatario;
        protected decimal valore;

        protected Spedizione (string mit, string des, decimal val)
        {
            this.mittente = mit;
            this.destinatario = des;
            this.valore = val;
        }

        //metodo astratto
        public abstract double printIngombro();


        //secondo metodo 
        public  bool Equal(Spedizione other)
        {
            return other.mittente==(mittente) 
                && other.destinatario==(destinatario)
                && other.valore==(valore)
                && other.printIngombro()==(printIngombro());
        }

        public string GetSpedizioni()
        {
            return $"Mittente: {mittente} / Destinatario: {destinatario} / Valore: {valore} / Ingombro totale: {printIngombro()}";
        }
    }
}