using System;
using System.Windows.Forms;
using Caelum.Banco.Clientes;
using Caelum.Banco.Contas;

namespace Banco {
    public partial class FormCadastrarConta : Form {
        private Form1 formPrincipal;

        public FormCadastrarConta(Form1 formPrincipal) {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastrarConta_Load(object sender, EventArgs e) {
            txtNumero.Text = Conta.ProximaConta().ToString();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e) {
            Conta novaConta = new ContaCorrente(new Cliente(txtTitular.Text));
            this.formPrincipal.AdicionaConta(novaConta);
        }
    }
}
