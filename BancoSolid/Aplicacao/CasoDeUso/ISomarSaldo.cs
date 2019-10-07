using BancoSolid.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public interface ISomarSaldo
    {
        public void SomarSaldo(decimal valor);
    }
}
