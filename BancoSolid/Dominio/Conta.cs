using BancoSolid.Aplicacao.CasoDeUso;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSolid.Dominio
{
    public abstract class Conta
    {
        public string Agencia { get; protected set; }
        public string NumConta { get; protected set; }
        public Saldo Saldo { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public Extrato Extrato { get; protected set; }
    }
}
