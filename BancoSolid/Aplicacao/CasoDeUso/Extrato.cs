using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Aplicacao.CasoDeUso
{
    public class Extrato : IExtrato
    {
        public List<string> ExtratoConta { get; set; }

        public Extrato()
        {
            ExtratoConta = new List<string>();
        }

        public void AtualizarExtrato(string descricao)
        {
            ExtratoConta.Add(descricao);
        }
    }
}
