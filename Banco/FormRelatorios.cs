using System;
using Caelum.Banco.Contas;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Banco {
    public partial class FormRelatorios : Form {
        List<Conta> contas;

        public FormRelatorios(List<Conta> contas) {
            InitializeComponent();
            this.contas = contas;
        }

        private void FormRelatorios_Load(object sender, EventArgs e) {
            var saldoTotal = this.contas.Sum(c =>  c.Saldo);
            var maiorSaldo = this.contas.Max(c => c.Saldo);

            lblSaldoTotal.Text = saldoTotal.ToString();
            lblMaiorSaldo.Text = maiorSaldo.ToString();
        }

        private void Button1_Click(object sender, EventArgs e) {
            listBoxRelatorios.Items.Clear();

            var resultado = from c in this.contas where c.Saldo > 100.0 select c;

            foreach (var conta in resultado) {
                listBoxRelatorios.Items.Add(conta);
            }
        }

        private void BtnAntigas_Click(object sender, EventArgs e) {
            listBoxRelatorios.Items.Clear();

            var resultado = from c in this.contas where c.Numero < 10 && c.Saldo > 1000.0 select c;

            foreach (var conta in resultado) {
                listBoxRelatorios.Items.Add(conta);
            }
        }
    }
}
