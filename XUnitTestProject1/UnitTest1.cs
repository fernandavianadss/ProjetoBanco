using System;
using Xunit;
using XUnitTestProject1.Injecao;
using Autofac;
using BancoSolid.Aplicacao.CasoDeUso;
using BancoSolid.Dominio;

namespace XUnitTestProject1
{
    public class UnitTest1 : IClassFixture<Fixture>
    {
        public readonly IExtrato extrato;
        public readonly ISubtrairSaldo subtrairSaldo;
        public readonly ISomarSaldo somarSaldo;
        public readonly ITransferencia transferencia;
        public readonly IDeposito deposito;
        public readonly ISaque saque;

        public ContaCorrente ContaC;
        public ContaPoupanca ContaP;

        public Cliente Cliente1;

        public UnitTest1(Fixture fix)
        {
            extrato = fix.ContainerFix.Resolve<IExtrato>();
            subtrairSaldo = fix.ContainerFix.Resolve<ISubtrairSaldo>();
            somarSaldo = fix.ContainerFix.Resolve<ISomarSaldo>();
            transferencia = fix.ContainerFix.Resolve<ITransferencia>();
            deposito = fix.ContainerFix.Resolve<IDeposito>();
            saque = fix.ContainerFix.Resolve<ISaque>();

            Cliente1 = new Cliente("Joao");
            ContaC = new ContaCorrente("4162", "234567", Cliente1);
            ContaP = new ContaPoupanca("4165", "234568", Cliente1);

        }

        [Fact]
        public void TesteExtrato()
        {
            ContaC.Extrato.AtualizarExtrato("Deposito R$ 15,00");
            Assert.True(ContaC.Extrato.ExtratoConta[0]== "Deposito R$ 15,00");
        }

        [Fact]
        public void TesteSomarSaldo()
        {
            ContaC.Saldo.SomarSaldo(50m);
            Assert.True(ContaC.Saldo.SaldoConta == 50m);
        }

        [Fact]
        public void TesteSubtrairSaldo()
        {
            ContaC.Saldo.SubtrairSaldo(50m);
            Assert.True(ContaC.Saldo.SaldoConta == -50m);
        }

        [Fact]
        public void TesteTransferencia()
        {
            ContaC.Saldo.SomarSaldo(20m);
            transferencia.Executar(ContaC, ContaP, 10m);
            Assert.True(ContaC.Saldo.SaldoConta == ContaP.Saldo.SaldoConta);
        }

        [Fact]
        public void TesteDeposito()
        {
            deposito.Depositar(20m, ContaP);
            Assert.True(ContaP.Saldo.SaldoConta == 20m);
        }

        [Fact]
        public void TesteSaque()
        {
            ContaC.Saldo.SomarSaldo(20m);
            saque.Executar(10m, ContaC);
            Assert.True(ContaC.Saldo.SaldoConta == 10m);
        }
    }
}
