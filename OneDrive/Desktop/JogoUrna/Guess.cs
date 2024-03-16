using System;

namespace JogoUrna
{
    class Guess
    {
        public int PalpiteUsuario()
        {
            int chute;
            while (true)
            {
                Console.WriteLine("Dê o seu chute: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out chute) && chute > 0)
                {
                    return chute;
                }
                else
                {
                    Console.WriteLine("Opção inválida. O palpite deve ser um número inteiro maior que zero.");
                }
            }
        }
    }
}
