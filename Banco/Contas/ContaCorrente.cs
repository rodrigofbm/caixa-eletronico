using System;
using Caelum.Banco.Clientes;
using Caelum.Banco.CustomExceptions;

namespace Caelum.Banco.Contas {
    class ContaCorrente : Conta {
        public ContaCorrente(Cliente titular): base(titular) {}

        public override void Saca(double valor) {
            if (valor < 0.0) {
                throw new ArgumentException();
            }
            if (this.Saldo < valor + 0.05) {
                throw new SaldoInsuficienteException();
            }else {
                this.Saldo -= valor + 0.05;
            }
        }

        public override void Deposita(double valor) {
            if (valor < 0.0) {
                throw new ArgumentException();
            } else {
                this.Saldo += valor;
            }
        }
    }
}
