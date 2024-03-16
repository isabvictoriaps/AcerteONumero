using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoBolaUrna
{
    class Guess
    {
        public int PalpiteUsuario()
        {
            Console.WriteLine("Dê o seu chute: ");
            int chute = int.Parse(Console.ReadLine());
            return chute;
        }
    }
}