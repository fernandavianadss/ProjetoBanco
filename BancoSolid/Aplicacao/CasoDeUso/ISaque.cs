using BancoSolid.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public interface ISaque
    {
        public void Executar(decimal valor, Conta conta);
    }
}
