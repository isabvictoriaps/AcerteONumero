using System;
using System.Collections.Generic;

namespace JogoUrna
{
    class Computador
    {
        private Urna urna;
        private List<Bola> bolasNaUrna;
        public int NumeroSorteado { get; private set; }
        public int TotalAcumulado { get; private set; }

        public Computador(Urna urna)
        {
            this.urna = urna;
            this.bolasNaUrna = urna.ObterBolasNaUrna();
            TotalAcumulado = 0;
        }

        public int RetirarBolaUrna()
        {
            int index = new Random().Next(1, bolasNaUrna.Count);
            Bola bolaSorteada = bolasNaUrna[index];        
            return bolaSorteada.Numero;
        }
    }
}
