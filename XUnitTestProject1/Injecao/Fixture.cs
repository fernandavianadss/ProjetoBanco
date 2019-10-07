using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using BancoSolid.Aplicacao.CasoDeUso;
using BancoSolid.Dominio;

namespace XUnitTestProject1.Injecao
{
    public class Fixture
    {
        public IContainer ContainerFix { get; set; }

        public Fixture()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Extrato>().As<IExtrato>().InstancePerDependency();
            builder.RegisterType<Saldo>().As<ISubtrairSaldo>().InstancePerDependency();
            builder.RegisterType<Saldo>().As<ISomarSaldo>().InstancePerDependency();
            builder.RegisterType<Transferencia>().As<ITransferencia>().InstancePerDependency();
            builder.RegisterType<Deposito>().As<IDeposito>().InstancePerDependency();
            builder.RegisterType<Saque>().As<ISaque>().InstancePerDependency();

             ContainerFix = builder.Build();
        }

    }
}
