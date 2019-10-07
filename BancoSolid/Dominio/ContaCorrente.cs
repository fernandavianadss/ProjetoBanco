using BancoSolid.Aplicacao.CasoDeUso;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Dominio
{
    public class ContaCorrente : Conta
    {
        public decimal TaxaMensal { get; private set; }
        public DateTime DiaCobrancaTaxa { get; private set; }

        public ContaCorrente(string agencia, string numConta, Cliente cliente)
        {
            Agencia = agencia;
            NumConta = numConta;
            Saldo = new Saldo();
            Cliente = cliente;
            Extrato = new Extrato();

            TaxaMensal = 5m;
            DiaCobrancaTaxa = DateTime.Now;
        }

    }
}
