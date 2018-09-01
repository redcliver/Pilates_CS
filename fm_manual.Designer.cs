namespace Pilates_CS
{
    partial class fm_manual
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.cb_agenda = new System.Windows.Forms.ComboBox();
            this.bt_presenca = new System.Windows.Forms.Button();
            this.lb_aulas = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_paciente
            // 
            this.cb_paciente.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_paciente.FormattingEnabled = true;
            this.cb_paciente.Location = new System.Drawing.Point(22, 108);
            this.cb_paciente.Name = "cb_paciente";
            this.cb_paciente.Size = new System.Drawing.Size(448, 27);
            this.cb_paciente.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome do paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 57);
            this.label1.TabIndex = 24;
            this.label1.Text = "Presença Manual";
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_buscar.Location = new System.Drawing.Point(365, 150);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(105, 37);
            this.bt_buscar.TabIndex = 27;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_fechar.Location = new System.Drawing.Point(365, 401);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(105, 37);
            this.bt_fechar.TabIndex = 28;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // cb_agenda
            // 
            this.cb_agenda.Enabled = false;
            this.cb_agenda.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_agenda.FormattingEnabled = true;
            this.cb_agenda.Location = new System.Drawing.Point(17, 212);
            this.cb_agenda.Name = "cb_agenda";
            this.cb_agenda.Size = new System.Drawing.Size(224, 27);
            this.cb_agenda.TabIndex = 29;
            this.cb_agenda.Visible = false;
            // 
            // bt_presenca
            // 
            this.bt_presenca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_presenca.Enabled = false;
            this.bt_presenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_presenca.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_presenca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_presenca.Location = new System.Drawing.Point(365, 205);
            this.bt_presenca.Name = "bt_presenca";
            this.bt_presenca.Size = new System.Drawing.Size(105, 37);
            this.bt_presenca.TabIndex = 30;
            this.bt_presenca.Text = "Presença";
            this.bt_presenca.UseVisualStyleBackColor = false;
            this.bt_presenca.Visible = false;
            this.bt_presenca.Click += new System.EventHandler(this.bt_presenca_Click);
            // 
            // lb_aulas
            // 
            this.lb_aulas.AutoSize = true;
            this.lb_aulas.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_aulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_aulas.Location = new System.Drawing.Point(17, 183);
            this.lb_aulas.Name = "lb_aulas";
            this.lb_aulas.Size = new System.Drawing.Size(52, 26);
            this.lb_aulas.TabIndex = 31;
            this.lb_aulas.Text = "Aulas";
            this.lb_aulas.Visible = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(14, 414);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(29, 13);
            this.lb_id.TabIndex = 32;
            this.lb_id.Text = "lb_id";
            this.lb_id.Visible = false;
            // 
            // fm_manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_aulas);
            this.Controls.Add(this.bt_presenca);
            this.Controls.Add(this.cb_agenda);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.cb_paciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_manual";
            this.Load += new System.EventHandler(this.fm_manual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_paciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.ComboBox cb_agenda;
        private System.Windows.Forms.Button bt_presenca;
        private System.Windows.Forms.Label lb_aulas;
        private System.Windows.Forms.Label lb_id;
    }
}