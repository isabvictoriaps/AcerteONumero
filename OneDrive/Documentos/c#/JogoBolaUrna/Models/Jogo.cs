using System;

namespace JogoBolaUrna.Models
{
    class Jogo
    {
        private Computador computador;
        private Guess guess = new Guess();
        private int numeroSorteio;

        public Jogo(Computador computador)
        {
            this.computador = computador;
            numeroSorteio = computador.RetirarBolaUrna(); 
        }

        public void IniciarJogo()
        {
            bool venceuJogo = false;

            while (!venceuJogo && numeroSorteio <= 100)
            {
                int palpite = guess.PalpiteUsuario();

                if (comparaValores(numeroSorteio, palpite)) 
                {
                    venceuJogo = true;
                    Console.WriteLine("Parabéns, você ganhou!");
                    break;
                }
                else
                {
                    Console.WriteLine("Tente novamente!");
                    int numeroSorteado = computador.RetirarBolaUrna();
                    numeroSorteio += numeroSorteado; 
                }
            }

            if (numeroSorteio > 100)
            {
                Console.WriteLine("Que pena! O número sorteado ultrapassou 100. Você perdeu!");
            }
        }

        private bool comparaValores(int totalAcumulado, int palpiteUsuario) 
        {
            if (totalAcumulado == palpiteUsuario) 
            {
                return true;
            }
            else
            {
                Console.WriteLine("Que pena! Você errou! Seu palpite foi " + palpiteUsuario + " e o numero sorteado foi " + totalAcumulado);
                return false;
            }
        }
    }
}
