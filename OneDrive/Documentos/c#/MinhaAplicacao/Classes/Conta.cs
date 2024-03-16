using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalBank.Contratos;

namespace DigitalBank.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {

        }

        public double Saldo { get; protected set; }
        public double NumeroAgencia { get; private set; }
        public double NumeroDaConta { get; private set; }


        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor; 
        }

        public bool Saca(double valor)
        {
            if (valor > this.ConsultaSaldo())
                return false;

            this.Saldo -= valor;
            return true;
           
        }

        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroAgencia;
        }

        public string GetNumeroDaConta()
        {
            return this.NumeroDaConta;
        }
    }
}
