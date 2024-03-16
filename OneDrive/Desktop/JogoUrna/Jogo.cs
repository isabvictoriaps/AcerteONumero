using System;
using JogoUrna;

namespace JogoUrna
{
    class Jogo
    {
        private Computador computador;
        private Guess guess = new Guess();
        private int totalAcumulado; 

        public Jogo(Computador computador)
        {
            this.computador = computador;
            totalAcumulado = computador.RetirarBolaUrna(); 
        }

        public void IniciarJogo()
        {
            bool venceuJogo = false;

            while (!venceuJogo && totalAcumulado <= 100)
            {
                int palpite = guess.PalpiteUsuario();

                if (comparaValores(totalAcumulado, palpite)) 
                {
                    venceuJogo = true;
                    Console.WriteLine("Parabéns, você ganhou!");
                    break;
                }
                else
                {
                    Console.WriteLine("Tente novamente!");
                    int numeroSorteado = computador.RetirarBolaUrna(); 
                    totalAcumulado += numeroSorteado; 
                }
            }

            if (totalAcumulado > 100)
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
                Console.WriteLine("Que pena! Você errou! Seu palpite foi " + palpiteUsuario + " e o número sorteado foi " + totalAcumulado);
                return false;
            }
        }
    }
}
