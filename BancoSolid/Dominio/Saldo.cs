using BancoSolid.Aplicacao.CasoDeUso;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Dominio
{
    public class Saldo : ISomarSaldo, ISubtrairSaldo
    {
        public decimal SaldoConta { get; set; }
        public Saldo()
        {
            SaldoConta = 0m;
        }

        public void SomarSaldo(decimal valor)
        {
            SaldoConta += valor; 
        }

        public void SubtrairSaldo(decimal valor)
        {
            SaldoConta -= valor;
        }
    }
}
