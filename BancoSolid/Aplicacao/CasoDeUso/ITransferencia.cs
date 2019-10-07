using BancoSolid.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public interface ITransferencia
    {
        public void Executar(Conta contaOrigem, Conta contaDestino, decimal valor);

    }
}
