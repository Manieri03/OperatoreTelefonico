using System;

namespace LibreriaTelefono
{
    public class Contatto
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public long NTel { get; private set; }

        public Contatto(string Nome, string Cognome, long NTel)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            if (NTel.ToString().Length != 10)
                throw new Exception("Il numero deve contenere esattamente 10 cifre");
            else
                this.NTel = NTel;
        }
    }
}
