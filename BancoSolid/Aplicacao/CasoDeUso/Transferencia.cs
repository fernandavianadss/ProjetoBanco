using BancoSolid.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public class Transferencia : ITransferencia
    {
        public void Executar(Conta contaOrigem, Conta contaDestino, decimal valor)
        {
            contaOrigem.Saldo.SubtrairSaldo(valor);
            contaDestino.Saldo.SomarSaldo(valor);
            contaOrigem.Extrato.AtualizarExtrato("Transferencia do valor");
            contaDestino.Extrato.AtualizarExtrato("Recebido transferencia do valor");
        }
    }
}
