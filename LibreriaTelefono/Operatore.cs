using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaTelefono
{
    public class Operatore
    {
        public string Nome { get; private set; }
        public List<Sim> SimList { get; private set; } = new List<Sim>();

        public Operatore(string Nome)
        {
            this.Nome = Nome;
        }

        public Sim AggiungiSim(string NTel)
        {
            Sim sim = new Sim(NTel, 10.0);
            SimList.Add(sim);
            return sim;
        }


        public void Ricarica(int seriale, double ricarica)
        {
            bool controllo = false;
            foreach (Sim s in SimList)
            {
                if (s.Seriale == seriale)
                {
                    s.Credito += ricarica;
                    controllo = true;
                }
            }
            if (controllo == false)
            {
                throw new Exception("Numero seriale inesistente");
            }
        }

        public string StampaSim(int seriale)
        {
            string sim = "";
            foreach (Sim s in SimList)
            {
                if (s.Seriale == seriale)
                {
                    sim = s.StampaSim();
                }
                else
                {
                    sim = "Sim inesistente";
                }
            }
            return sim;
        }

    }
}
