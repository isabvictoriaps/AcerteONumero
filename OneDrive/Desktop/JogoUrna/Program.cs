using System;
using JogoUrna;

namespace JogoUrna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao ADIVINHE O ALVO");
            Console.WriteLine("O desafio é: acertar o valor que o computador sorteou.");
            Console.WriteLine("");

            Urna urna = new Urna();

            Computador computador = new Computador(urna);

            Jogo jogo = new Jogo(computador);

            jogo.IniciarJogo();
        }
    }
}
