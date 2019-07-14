using System;
using Caelum.Banco.Clientes;
using Caelum.Banco.CustomExceptions;
using Caelum.Banco.CustomInterfaces;

namespace Caelum.Banco.Contas {
    class ContaInvestimento : Conta, ITributavel {
        public ContaInvestimento(Cliente titular): base(titular) {

        }

        public override void Saca(double valor) {
            if (valor < 0.0) {
                throw new ArgumentException();
            }
            if (this.Saldo < valor) {
                throw new SaldoInsuficienteException();
            } else {
                this.Saldo -= valor;
            }
        }

        public override void Deposita(double valor) {
            if(valor < 0.0) {
                throw new ArgumentException();
            } else {
                this.Saldo += valor;
            }
        }

        public double CalculaTributo() {
            return this.Saldo * 0.02;
        }
    }
}
