using System;
using System.Collections.Generic;
using System.Text;
using BancoSolid.Dominio;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public class Deposito : IDeposito
    {
        public void Depositar(decimal valor, Conta conta)
        {
            conta.Saldo.SomarSaldo(valor);
            conta.Extrato.AtualizarExtrato("Deposito efetuado com sucesso");
        }
    }
}
