namespace Pilates_CS
{
    partial class fm_pagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_paciente = new System.Windows.Forms.ComboBox();
            this.bt_fecha = new System.Windows.Forms.Button();
            this.bt_pagamento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_plano = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_dinheiro = new System.Windows.Forms.RadioButton();
            this.rb_debito = new System.Windows.Forms.RadioButton();
            this.rb_credito = new System.Windows.Forms.RadioButton();
            this.rb_individual = new System.Windows.Forms.RadioButton();
            this.rb_dupla = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_paciente
            // 
            this.cb_paciente.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_paciente.FormattingEnabled = true;
            this.cb_paciente.Location = new System.Drawing.Point(22, 107);
            this.cb_paciente.Name = "cb_paciente";
            this.cb_paciente.Size = new System.Drawing.Size(448, 27);
            this.cb_paciente.TabIndex = 23;
            // 
            // bt_fecha
            // 
            this.bt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fecha.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_fecha.Location = new System.Drawing.Point(22, 351);
            this.bt_fecha.Name = "bt_fecha";
            this.bt_fecha.Size = new System.Drawing.Size(105, 37);
            this.bt_fecha.TabIndex = 22;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // bt_pagamento
            // 
            this.bt_pagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_pagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pagamento.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_pagamento.Location = new System.Drawing.Point(365, 351);
            this.bt_pagamento.Name = "bt_pagamento";
            this.bt_pagamento.Size = new System.Drawing.Size(105, 37);
            this.bt_pagamento.TabIndex = 21;
            this.bt_pagamento.Text = "Registrar";
            this.bt_pagamento.UseVisualStyleBackColor = false;
            this.bt_pagamento.Click += new System.EventHandler(this.bt_pagamento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome do paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 57);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pagamentos";
            // 
            // cb_plano
            // 
            this.cb_plano.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_plano.FormattingEnabled = true;
            this.cb_plano.Location = new System.Drawing.Point(22, 180);
            this.cb_plano.Name = "cb_plano";
            this.cb_plano.Size = new System.Drawing.Size(163, 27);
            this.cb_plano.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(18, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 33;
            this.label6.Text = "Plano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(284, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Método de pag.";
            // 
            // rb_dinheiro
            // 
            this.rb_dinheiro.AutoSize = true;
            this.rb_dinheiro.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.rb_dinheiro.Location = new System.Drawing.Point(289, 184);
            this.rb_dinheiro.Name = "rb_dinheiro";
            this.rb_dinheiro.Size = new System.Drawing.Size(93, 30);
            this.rb_dinheiro.TabIndex = 39;
            this.rb_dinheiro.TabStop = true;
            this.rb_dinheiro.Text = "Dinheiro";
            this.rb_dinheiro.UseVisualStyleBackColor = true;
            // 
            // rb_debito
            // 
            this.rb_debito.AutoSize = true;
            this.rb_debito.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.rb_debito.Location = new System.Drawing.Point(289, 207);
            this.rb_debito.Name = "rb_debito";
            this.rb_debito.Size = new System.Drawing.Size(120, 30);
            this.rb_debito.TabIndex = 40;
            this.rb_debito.TabStop = true;
            this.rb_debito.Text = "Cartão Deb.";
            this.rb_debito.UseVisualStyleBackColor = true;
            // 
            // rb_credito
            // 
            this.rb_credito.AutoSize = true;
            this.rb_credito.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.rb_credito.Location = new System.Drawing.Point(289, 230);
            this.rb_credito.Name = "rb_credito";
            this.rb_credito.Size = new System.Drawing.Size(127, 30);
            this.rb_credito.TabIndex = 41;
            this.rb_credito.TabStop = true;
            this.rb_credito.Text = "Cartão Cred.";
            this.rb_credito.UseVisualStyleBackColor = true;
            // 
            // rb_individual
            // 
            this.rb_individual.AutoSize = true;
            this.rb_individual.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.rb_individual.Location = new System.Drawing.Point(3, 3);
            this.rb_individual.Name = "rb_individual";
            this.rb_individual.Size = new System.Drawing.Size(103, 30);
            this.rb_individual.TabIndex = 35;
            this.rb_individual.TabStop = true;
            this.rb_individual.Text = "Individual";
            this.rb_individual.UseVisualStyleBackColor = true;
            // 
            // rb_dupla
            // 
            this.rb_dupla.AutoSize = true;
            this.rb_dupla.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.rb_dupla.Location = new System.Drawing.Point(3, 26);
            this.rb_dupla.Name = "rb_dupla";
            this.rb_dupla.Size = new System.Drawing.Size(74, 30);
            this.rb_dupla.TabIndex = 36;
            this.rb_dupla.TabStop = true;
            this.rb_dupla.Text = "Dupla";
            this.rb_dupla.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_dupla);
            this.panel1.Controls.Add(this.rb_individual);
            this.panel1.Location = new System.Drawing.Point(23, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 42;
            // 
            // fm_pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(495, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rb_credito);
            this.Controls.Add(this.rb_debito);
            this.Controls.Add(this.rb_dinheiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_plano);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_paciente);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.bt_pagamento);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_pagamento";
            this.Load += new System.EventHandler(this.fm_pagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_paciente;
        private System.Windows.Forms.Button bt_fecha;
        private System.Windows.Forms.Button bt_pagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_plano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_dinheiro;
        private System.Windows.Forms.RadioButton rb_debito;
        private System.Windows.Forms.RadioButton rb_credito;
        private System.Windows.Forms.RadioButton rb_individual;
        private System.Windows.Forms.RadioButton rb_dupla;
        private System.Windows.Forms.Panel panel1;
    }
}