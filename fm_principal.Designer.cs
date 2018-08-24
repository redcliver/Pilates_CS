namespace Pilates_CS
{
    partial class fm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_outro = new System.Windows.Forms.Button();
            this.bt_paciente = new System.Windows.Forms.Button();
            this.bt_agenda = new System.Windows.Forms.Button();
            this.bt_presenca = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_principal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bt_outro);
            this.panel1.Controls.Add(this.bt_paciente);
            this.panel1.Controls.Add(this.bt_agenda);
            this.panel1.Controls.Add(this.bt_presenca);
            this.panel1.Controls.Add(this.bt_sair);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 136);
            this.panel1.TabIndex = 0;
            // 
            // bt_outro
            // 
            this.bt_outro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_outro.Location = new System.Drawing.Point(1144, 30);
            this.bt_outro.Name = "bt_outro";
            this.bt_outro.Size = new System.Drawing.Size(75, 75);
            this.bt_outro.TabIndex = 4;
            this.bt_outro.UseVisualStyleBackColor = true;
            this.bt_outro.Click += new System.EventHandler(this.bt_outro_Click);
            // 
            // bt_paciente
            // 
            this.bt_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_paciente.Location = new System.Drawing.Point(834, 30);
            this.bt_paciente.Name = "bt_paciente";
            this.bt_paciente.Size = new System.Drawing.Size(87, 75);
            this.bt_paciente.TabIndex = 3;
            this.bt_paciente.UseVisualStyleBackColor = true;
            this.bt_paciente.Click += new System.EventHandler(this.bt_paciente_Click);
            // 
            // bt_agenda
            // 
            this.bt_agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agenda.Location = new System.Drawing.Point(940, 30);
            this.bt_agenda.Name = "bt_agenda";
            this.bt_agenda.Size = new System.Drawing.Size(75, 75);
            this.bt_agenda.TabIndex = 2;
            this.bt_agenda.UseVisualStyleBackColor = true;
            this.bt_agenda.Click += new System.EventHandler(this.bt_agenda_Click);
            // 
            // bt_presenca
            // 
            this.bt_presenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_presenca.Location = new System.Drawing.Point(1034, 37);
            this.bt_presenca.Name = "bt_presenca";
            this.bt_presenca.Size = new System.Drawing.Size(99, 60);
            this.bt_presenca.TabIndex = 1;
            this.bt_presenca.UseVisualStyleBackColor = true;
            this.bt_presenca.Click += new System.EventHandler(this.bt_presenca_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Transparent;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Location = new System.Drawing.Point(1225, 30);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 75);
            this.bt_sair.TabIndex = 1;
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\HeadTec\\source\\repos\\Pilates_CS\\Logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(10, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_principal
            // 
            this.pn_principal.BackColor = System.Drawing.Color.Transparent;
            this.pn_principal.Location = new System.Drawing.Point(100, 142);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(1160, 527);
            this.pn_principal.TabIndex = 2;
            // 
            // fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.pn_principal);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - Core Fit - Estúdio De Pilates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_outro;
        private System.Windows.Forms.Button bt_paciente;
        private System.Windows.Forms.Button bt_agenda;
        private System.Windows.Forms.Button bt_presenca;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Panel pn_principal;
    }
}