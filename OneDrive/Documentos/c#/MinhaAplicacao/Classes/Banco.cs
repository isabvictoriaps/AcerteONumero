using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Classes
{
    public abstract class Banco
    {
        public Banco() 
        {
            this.NomeDoBanco = "DigiBank";
            this.CodigoDoBanco = "187";
        }

        public String NomeDoBanco { get; private set; }
        public String CodigoDoBanco { get; private set; }

    }
}
