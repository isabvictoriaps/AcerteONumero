using System;
using JogoBolaUrna.Models;

namespace JogoBolaUrna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem-vindo ao jogo de adivinhação");
            Console.WriteLine(" ");
            Console.WriteLine("O objetivo é você adivinhar o número da bola retirada da urna! Bora lá?");
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------------------");

            Urna urna = new Urna();
            Computador computador = new Computador(urna);
            Jogo jogo = new Jogo(computador);

            jogo.IniciarJogo();

            Console.ReadLine();
        }
    }
}
