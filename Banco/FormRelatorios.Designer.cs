namespace Banco {
    partial class FormRelatorios {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBoxRelatorios = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAntigas = new System.Windows.Forms.Button();
            this.groupBoxResumo = new System.Windows.Forms.GroupBox();
            this.lblSaltoTot = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblMaiorSald = new System.Windows.Forms.Label();
            this.lblMaiorSaldo = new System.Windows.Forms.Label();
            this.groupBoxResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRelatorios
            // 
            this.listBoxRelatorios.FormattingEnabled = true;
            this.listBoxRelatorios.Location = new System.Drawing.Point(26, 12);
            this.listBoxRelatorios.Name = "listBoxRelatorios";
            this.listBoxRelatorios.Size = new System.Drawing.Size(269, 95);
            this.listBoxRelatorios.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Saldo > 100, 00";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAntigas
            // 
            this.btnAntigas.Location = new System.Drawing.Point(197, 206);
            this.btnAntigas.Name = "btnAntigas";
            this.btnAntigas.Size = new System.Drawing.Size(98, 23);
            this.btnAntigas.TabIndex = 2;
            this.btnAntigas.Text = "Antigas";
            this.btnAntigas.UseVisualStyleBackColor = true;
            this.btnAntigas.Click += new System.EventHandler(this.BtnAntigas_Click);
            // 
            // groupBoxResumo
            // 
            this.groupBoxResumo.Controls.Add(this.lblMaiorSaldo);
            this.groupBoxResumo.Controls.Add(this.lblMaiorSald);
            this.groupBoxResumo.Controls.Add(this.lblSaldoTotal);
            this.groupBoxResumo.Controls.Add(this.lblSaltoTot);
            this.groupBoxResumo.Location = new System.Drawing.Point(26, 123);
            this.groupBoxResumo.Name = "groupBoxResumo";
            this.groupBoxResumo.Size = new System.Drawing.Size(269, 77);
            this.groupBoxResumo.TabIndex = 3;
            this.groupBoxResumo.TabStop = false;
            this.groupBoxResumo.Text = "Resumo";
            // 
            // lblSaltoTot
            // 
            this.lblSaltoTot.AutoSize = true;
            this.lblSaltoTot.Location = new System.Drawing.Point(7, 20);
            this.lblSaltoTot.Name = "lblSaltoTot";
            this.lblSaltoTot.Size = new System.Drawing.Size(61, 13);
            this.lblSaltoTot.TabIndex = 0;
            this.lblSaltoTot.Text = "Saldo Total";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(120, 20);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(35, 13);
            this.lblSaldoTotal.TabIndex = 1;
            this.lblSaldoTotal.Text = "label1";
            // 
            // lblMaiorSald
            // 
            this.lblMaiorSald.AutoSize = true;
            this.lblMaiorSald.Location = new System.Drawing.Point(7, 49);
            this.lblMaiorSald.Name = "lblMaiorSald";
            this.lblMaiorSald.Size = new System.Drawing.Size(63, 13);
            this.lblMaiorSald.TabIndex = 2;
            this.lblMaiorSald.Text = "Maior Saldo";
            // 
            // lblMaiorSaldo
            // 
            this.lblMaiorSaldo.AutoSize = true;
            this.lblMaiorSaldo.Location = new System.Drawing.Point(120, 49);
            this.lblMaiorSaldo.Name = "lblMaiorSaldo";
            this.lblMaiorSaldo.Size = new System.Drawing.Size(35, 13);
            this.lblMaiorSaldo.TabIndex = 3;
            this.lblMaiorSaldo.Text = "label1";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 252);
            this.Controls.Add(this.groupBoxResumo);
            this.Controls.Add(this.btnAntigas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxRelatorios);
            this.Name = "FormRelatorios";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            this.groupBoxResumo.ResumeLayout(false);
            this.groupBoxResumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRelatorios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAntigas;
        private System.Windows.Forms.GroupBox groupBoxResumo;
        private System.Windows.Forms.Label lblMaiorSaldo;
        private System.Windows.Forms.Label lblMaiorSald;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblSaltoTot;
    }
}