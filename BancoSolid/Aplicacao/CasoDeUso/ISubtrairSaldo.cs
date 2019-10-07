using BancoSolid.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public interface ISubtrairSaldo
    {
        public void SubtrairSaldo(decimal valor);
    }
}
