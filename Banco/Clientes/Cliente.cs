namespace Caelum.Banco.Clientes {
    public class Cliente {
        public string Nome { get; private set; }

        public Cliente(string nome) {
            this.Nome = nome;
        }
    }
}