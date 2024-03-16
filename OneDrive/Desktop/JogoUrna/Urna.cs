using System;
using System.Collections.Generic;

namespace JogoUrna
{
    class Urna
    {
        private List<Bola> bolasNaUrna;

        public Urna()
        {
            bolasNaUrna = new List<Bola>();
            for (int i = 1; i <= 20; i++)
            {
                bolasNaUrna.Add(new Bola(i));
            }
            Console.WriteLine("20 bolas foram adicionas");
        }

        public List<Bola> ObterBolasNaUrna()
        {
            return bolasNaUrna;
        }

    }
}
