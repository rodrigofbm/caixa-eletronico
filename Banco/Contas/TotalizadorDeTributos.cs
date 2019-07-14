
using Caelum.Banco.CustomInterfaces;

namespace Caelum.Banco.Contas {
    class TotalizadorDeTributos {
        public double Total { get; private set; }

        public void Acumula(ITributavel conta) {
            // Com a Interface garantimos que o objeto passado em conta terá o método CalculaTributo, nesse exemplo
            this.Total += conta.CalculaTributo();
        }
    }
}
