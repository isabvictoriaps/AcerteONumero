using System;
using System.Collections.Generic;

namespace JogoUrna
{
    class Bola
    {
        public int Numero { get; private set; }
        public bool Sorteada { get; set; } 

        public Bola(int numero)
        {
            Numero = numero;
            Sorteada = false; 
        }
    }
}
