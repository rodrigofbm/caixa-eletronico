using Caelum.Banco.Clientes;

namespace Caelum.Banco.Contas {
    public abstract class Conta {
        public Cliente Titular { get; private set; }
        public double Saldo { get; protected set; } = 200.0;
        public int Numero { get; private set; }
        private static int totalDeContas = 0;

        public Conta(Cliente titular) {
            this.Titular = titular;
            totalDeContas++;
            this.Numero = totalDeContas;
        }

        public abstract void Saca(double valor);

        public abstract void Deposita(double valor);

        public bool Transfere(double valor, Conta destino) {
            
            return false;
        }
        
        public override string ToString() {
            return "Titular: " + this.Titular.Nome;
        }

        public static int ProximaConta() {
            return totalDeContas + 1;
        }

        // override object.Equals
        public override bool Equals(object obj) {
            if(!(obj is Conta)) {
                return false;
            }

            Conta c = (Conta)obj;
            return this.Numero == c.Numero;
        }
    }
}
