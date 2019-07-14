namespace Caelum.Banco.Contas {
    class TotalizadorDeContas {
        public double ValorTotal { get; private set; }

        public void Soma(Conta conta) {
            this.ValorTotal += conta.Saldo;
        }
    }
}
