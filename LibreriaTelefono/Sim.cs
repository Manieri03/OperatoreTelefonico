using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaTelefono
{
    public class Sim
    {
        public string NTel { get; private set; }
        public int Seriale { get; private set; }
        public double Credito { get; set; }
        public List<Telefonata> telefonate { get; private set; } = new List<Telefonata>();

        public Sim(string NTel, double Credito)
        {

            this.Credito = Credito;
            if (NTel.ToString().Length != 10)
                throw new Exception("Il numero deve contenere esattamente 10 cifre");
            else
                this.NTel = NTel;
            //Manca il codice seriale

        }
        public void AggiungiTelefonata(Telefonata t)
        {
            telefonate.Add(t);
        }

        public double CalcolaTotMinuti()
        {
            double tot = 0;
            foreach (Telefonata t in telefonate)
            {
                tot += t.Durata;
            }
            return tot;
        }

        public string CalcolaTelefonate(long NTel)
        {
            List<Telefonata> telefonate = new List<Telefonata>();
            foreach (Telefonata t in telefonate)
            {
                if (t.ContattoChiamato.NTel == NTel)
                    telefonate.Add(t);
            }
            
            return $"Sono state effettuate {telefonate.Count} telefonate al numero seguente: {NTel}";
        }

        public string StampaSim()
        {
            return $"La sim ha il seguente numero di telefono : {NTel} avente il numero seriale : {Seriale}, il credito residuo è di : {Credito}";
        }

        public string StampaTelefonate()
        {
            string chiamate = "";
            foreach (Telefonata t in telefonate)
            {
                chiamate += $"Telefonata fatta a {t.ContattoChiamato.Nome} {t.ContattoChiamato.Cognome} durata {t.Durata} minuti, in data {t.Data}";
            }
            return chiamate;
        }


    }
}
