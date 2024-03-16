using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoBolaUrna.Models;

namespace JogoBolaUrna.Models
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
            Console.WriteLine(bolasNaUrna.Count + "foram adicionadas na urna");

        }

        public List<Bola> ObterBolaNaUrna()
        {
            return bolasNaUrna;
        }


    }
}
