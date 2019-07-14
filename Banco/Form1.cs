using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Caelum.Banco.Clientes;
using Caelum.Banco.CustomExceptions;
using Caelum.Banco.Contas;

namespace Banco {
    public partial class Form1 : Form {
        private List<Conta> contas;
        int index = 0;
        //private int indice = 0;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.contas = new List<Conta>();

            Cliente cliente = new Cliente("Rodrigo");
            Cliente cliente2 = new Cliente("Diego");
            this.AdicionaConta(new ContaCorrente(cliente));
            this.AdicionaConta(new ContaPoupanca(cliente2));

            //ContaPoupanca conta = new ContaPoupanca(cliente, 3);
            //conta.Deposita(200.0);
            //MessageBox.Show("imposto	da	conta	corrente	=	" + conta.CalculaTributo());
            //ITributavel t = conta;
            //MessageBox.Show("imposto	da	conta	pela	interface	=	" + t.CalculaTributo());
        }

        private void BtnDeposita_Click(object sender, EventArgs e) {
            double valorDigitado = double.Parse(txtValor.Text);
            try {
                this.contas[index].Deposita(valorDigitado);
                txtSaldo.Text = this.contas[index].Saldo.ToString("F2");
                MessageBox.Show("Sucesso!");
            } catch (ArgumentException err) {
                MessageBox.Show("Não é possível depositar um valor negativo");
            }
        }

        private void BtnSaque_Click(object sender, EventArgs e) {
            double valorDigitado = double.Parse(txtValor.Text);
            try {
                this.contas[index].Saca(valorDigitado);
                txtSaldo.Text = this.contas[index].Saldo.ToString("F2");
                MessageBox.Show("Sucesso!");
            } catch (SaldoInsuficienteException err) {
                MessageBox.Show("Saldo insuficiente");
            }catch(ArgumentException err) {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
        }

        private void CBoxBusca_SelectedIndexChanged(object sender, EventArgs e) {
            index = cBoxBusca.SelectedIndex;

            txtTitular.Text = this.contas[index].Titular.Nome;
            txtSaldo.Text = this.contas[index].Saldo.ToString("F2");
            txtNumero.Text = this.contas[index].Numero.ToString();
        }

        public void AdicionaConta(Conta conta) {
            this.contas.Add(conta);
            //this.indice++;
            cBoxBusca.Items.Add(conta);
        }

        private void BtnNovaConta_Click(object sender, EventArgs e) {
            FormCadastrarConta formCadastrarConta = new FormCadastrarConta(this);
            formCadastrarConta.ShowDialog();
        }
    }
}
