using System;
using System.Collections.Generic;
using System.Text;
using BancoSolid.Dominio;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public class Saque : ISaque
    {
        public void Executar(decimal valor, Conta conta)
        {
            conta.Saldo.SubtrairSaldo(valor);
            conta.Extrato.AtualizarExtrato("Saque Realizado com sucesso");
        }
    }
}
