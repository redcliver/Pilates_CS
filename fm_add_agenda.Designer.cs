namespace Pilates_CS
{
    partial class fm_add_agenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_paciente = new System.Windows.Forms.ComboBox();
            this.bt_fecha = new System.Windows.Forms.Button();
            this.bt_agendar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_prof = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_plano = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mc_data = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 57);
            this.label1.TabIndex = 18;
            this.label1.Text = "Novo agendamento";
            // 
            // cb_paciente
            // 
            this.cb_paciente.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_paciente.FormattingEnabled = true;
            this.cb_paciente.Location = new System.Drawing.Point(22, 108);
            this.cb_paciente.Name = "cb_paciente";
            this.cb_paciente.Size = new System.Drawing.Size(448, 27);
            this.cb_paciente.TabIndex = 23;
            this.cb_paciente.SelectedIndexChanged += new System.EventHandler(this.cb_paciente_SelectedIndexChanged);
            // 
            // bt_fecha
            // 
            this.bt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fecha.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_fecha.Location = new System.Drawing.Point(22, 442);
            this.bt_fecha.Name = "bt_fecha";
            this.bt_fecha.Size = new System.Drawing.Size(105, 37);
            this.bt_fecha.TabIndex = 22;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // bt_agendar
            // 
            this.bt_agendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_agendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agendar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_agendar.Location = new System.Drawing.Point(365, 442);
            this.bt_agendar.Name = "bt_agendar";
            this.bt_agendar.Size = new System.Drawing.Size(105, 37);
            this.bt_agendar.TabIndex = 21;
            this.bt_agendar.Text = "Agendar";
            this.bt_agendar.UseVisualStyleBackColor = false;
            this.bt_agendar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome do paciente";
            // 
            // cb_prof
            // 
            this.cb_prof.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_prof.FormattingEnabled = true;
            this.cb_prof.Location = new System.Drawing.Point(22, 187);
            this.cb_prof.Name = "cb_prof";
            this.cb_prof.Size = new System.Drawing.Size(448, 27);
            this.cb_prof.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome do profissional";
            // 
            // cb_horario
            // 
            this.cb_horario.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(281, 266);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(163, 27);
            this.cb_horario.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(276, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hora";
            // 
            // cb_plano
            // 
            this.cb_plano.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_plano.FormattingEnabled = true;
            this.cb_plano.Location = new System.Drawing.Point(280, 343);
            this.cb_plano.Name = "cb_plano";
            this.cb_plano.Size = new System.Drawing.Size(163, 27);
            this.cb_plano.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(276, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 31;
            this.label6.Text = "Plano";
            // 
            // mc_data
            // 
            this.mc_data.Location = new System.Drawing.Point(18, 237);
            this.mc_data.MaxSelectionCount = 1;
            this.mc_data.Name = "mc_data";
            this.mc_data.TabIndex = 33;
            // 
            // fm_add_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(501, 499);
            this.Controls.Add(this.mc_data);
            this.Controls.Add(this.cb_plano);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_prof);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_paciente);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.bt_agendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_add_agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_agenda";
            this.Load += new System.EventHandler(this.fm_add_agenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_paciente;
        private System.Windows.Forms.Button bt_fecha;
        private System.Windows.Forms.Button bt_agendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_prof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_plano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar mc_data;
    }
}