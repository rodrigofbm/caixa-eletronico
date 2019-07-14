namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeposita = new System.Windows.Forms.Button();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.gBoxConta = new System.Windows.Forms.GroupBox();
            this.gBoxOperacoes = new System.Windows.Forms.GroupBox();
            this.gBoxBuscar = new System.Windows.Forms.GroupBox();
            this.cBoxBusca = new System.Windows.Forms.ComboBox();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.gBoxConta.SuspendLayout();
            this.gBoxOperacoes.SuspendLayout();
            this.gBoxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeposita
            // 
            this.btnDeposita.Location = new System.Drawing.Point(17, 91);
            this.btnDeposita.Name = "btnDeposita";
            this.btnDeposita.Size = new System.Drawing.Size(75, 23);
            this.btnDeposita.TabIndex = 0;
            this.btnDeposita.Text = "Depositar";
            this.btnDeposita.UseVisualStyleBackColor = true;
            this.btnDeposita.Click += new System.EventHandler(this.BtnDeposita_Click);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(18, 14);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 1;
            this.lblTitular.Text = "Titular";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(20, 40);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(20, 101);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(21, 150);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(17, 40);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(18, 124);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo";
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(120, 91);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 8;
            this.btnSaque.Text = "Sacar";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.BtnSaque_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(18, 75);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(35, 13);
            this.lblConta.TabIndex = 9;
            this.lblConta.Text = "Conta";
            // 
            // gBoxConta
            // 
            this.gBoxConta.Controls.Add(this.txtTitular);
            this.gBoxConta.Controls.Add(this.lblConta);
            this.gBoxConta.Controls.Add(this.lblTitular);
            this.gBoxConta.Controls.Add(this.txtNumero);
            this.gBoxConta.Controls.Add(this.lblSaldo);
            this.gBoxConta.Controls.Add(this.txtSaldo);
            this.gBoxConta.Location = new System.Drawing.Point(12, 75);
            this.gBoxConta.Name = "gBoxConta";
            this.gBoxConta.Size = new System.Drawing.Size(234, 219);
            this.gBoxConta.TabIndex = 10;
            this.gBoxConta.TabStop = false;
            this.gBoxConta.Text = "Conta";
            // 
            // gBoxOperacoes
            // 
            this.gBoxOperacoes.Controls.Add(this.txtValor);
            this.gBoxOperacoes.Controls.Add(this.btnDeposita);
            this.gBoxOperacoes.Controls.Add(this.btnSaque);
            this.gBoxOperacoes.Controls.Add(this.label2);
            this.gBoxOperacoes.Location = new System.Drawing.Point(12, 320);
            this.gBoxOperacoes.Name = "gBoxOperacoes";
            this.gBoxOperacoes.Size = new System.Drawing.Size(234, 122);
            this.gBoxOperacoes.TabIndex = 11;
            this.gBoxOperacoes.TabStop = false;
            this.gBoxOperacoes.Text = "Operações";
            // 
            // gBoxBuscar
            // 
            this.gBoxBuscar.Controls.Add(this.cBoxBusca);
            this.gBoxBuscar.Location = new System.Drawing.Point(12, 13);
            this.gBoxBuscar.Name = "gBoxBuscar";
            this.gBoxBuscar.Size = new System.Drawing.Size(234, 56);
            this.gBoxBuscar.TabIndex = 12;
            this.gBoxBuscar.TabStop = false;
            this.gBoxBuscar.Text = "Buscar";
            // 
            // cBoxBusca
            // 
            this.cBoxBusca.FormattingEnabled = true;
            this.cBoxBusca.Location = new System.Drawing.Point(17, 19);
            this.cBoxBusca.Name = "cBoxBusca";
            this.cBoxBusca.Size = new System.Drawing.Size(104, 21);
            this.cBoxBusca.TabIndex = 2;
            this.cBoxBusca.SelectedIndexChanged += new System.EventHandler(this.CBoxBusca_SelectedIndexChanged);
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(29, 450);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btnNovaConta.TabIndex = 13;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.BtnNovaConta_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(132, 450);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorios.TabIndex = 14;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 485);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.gBoxBuscar);
            this.Controls.Add(this.gBoxOperacoes);
            this.Controls.Add(this.gBoxConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxConta.ResumeLayout(false);
            this.gBoxConta.PerformLayout();
            this.gBoxOperacoes.ResumeLayout(false);
            this.gBoxOperacoes.PerformLayout();
            this.gBoxBuscar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeposita;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.GroupBox gBoxConta;
        private System.Windows.Forms.GroupBox gBoxOperacoes;
        private System.Windows.Forms.GroupBox gBoxBuscar;
        private System.Windows.Forms.ComboBox cBoxBusca;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Button btnRelatorios;
    }
}

