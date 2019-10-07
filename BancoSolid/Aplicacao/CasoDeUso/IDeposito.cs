using BancoSolid.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public  interface IDeposito
    {
        public void Depositar(decimal valor, Conta conta);
    }
}
