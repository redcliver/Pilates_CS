﻿namespace Pilates_CS
{
    partial class fm_entrada
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
            this.bt_fecha = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_credito = new System.Windows.Forms.RadioButton();
            this.rb_debito = new System.Windows.Forms.RadioButton();
            this.rb_dinheiro = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_fecha
            // 
            this.bt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fecha.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_fecha.Location = new System.Drawing.Point(14, 289);
            this.bt_fecha.Name = "bt_fecha";
            this.bt_fecha.Size = new System.Drawing.Size(105, 37);
            this.bt_fecha.TabIndex = 36;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_salvar.Location = new System.Drawing.Point(367, 289);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(105, 37);
            this.bt_salvar.TabIndex = 35;
            this.bt_salvar.Text = "Registrar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(23, 158);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(251, 85);
            this.tb_desc.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Descrição";
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(23, 96);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(108, 20);
            this.tb_valor.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor da entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 57);
            this.label1.TabIndex = 28;
            this.label1.Text = "Entrada";
            // 
            // rb_credito
            // 
            this.rb_credito.AutoSize = true;
            this.rb_credito.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.rb_credito.Location = new System.Drawing.Point(324, 208);
            this.rb_credito.Name = "rb_credito";
            this.rb_credito.Size = new System.Drawing.Size(127, 30);
            this.rb_credito.TabIndex = 45;
            this.rb_credito.TabStop = true;
            this.rb_credito.Text = "Cartão Cred.";
            this.rb_credito.UseVisualStyleBackColor = true;
            // 
            // rb_debito
            // 
            this.rb_debito.AutoSize = true;
            this.rb_debito.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.rb_debito.Location = new System.Drawing.Point(324, 185);
            this.rb_debito.Name = "rb_debito";
            this.rb_debito.Size = new System.Drawing.Size(120, 30);
            this.rb_debito.TabIndex = 44;
            this.rb_debito.TabStop = true;
            this.rb_debito.Text = "Cartão Deb.";
            this.rb_debito.UseVisualStyleBackColor = true;
            // 
            // rb_dinheiro
            // 
            this.rb_dinheiro.AutoSize = true;
            this.rb_dinheiro.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.rb_dinheiro.Location = new System.Drawing.Point(324, 162);
            this.rb_dinheiro.Name = "rb_dinheiro";
            this.rb_dinheiro.Size = new System.Drawing.Size(93, 30);
            this.rb_dinheiro.TabIndex = 43;
            this.rb_dinheiro.TabStop = true;
            this.rb_dinheiro.Text = "Dinheiro";
            this.rb_dinheiro.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(319, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "Método";
            // 
            // fm_entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 338);
            this.Controls.Add(this.rb_credito);
            this.Controls.Add(this.rb_debito);
            this.Controls.Add(this.rb_dinheiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_fecha;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_credito;
        private System.Windows.Forms.RadioButton rb_debito;
        private System.Windows.Forms.RadioButton rb_dinheiro;
        private System.Windows.Forms.Label label3;
    }
}