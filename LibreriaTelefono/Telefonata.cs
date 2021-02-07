using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaTelefono
{
    public class Telefonata
    {
        public DateTime Data { get; private set; }
        public double Durata { get; private set; }
        public Contatto ContattoChiamato { get; private set; }

        public Telefonata(DateTime Data, double Durata, Contatto ContattoChiamato)
        {
            this.Data = Data;
            this.Durata = Durata;
            this.ContattoChiamato = ContattoChiamato;
        }
    }
}
