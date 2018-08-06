namespace Pilates_CS
{
    partial class fm_paciente
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
            this.bt_busca = new System.Windows.Forms.Button();
            this.bt_novoPac = new System.Windows.Forms.Button();
            this.bt_fecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paciente";
            // 
            // bt_busca
            // 
            this.bt_busca.BackColor = System.Drawing.Color.Transparent;
            this.bt_busca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_busca.FlatAppearance.BorderSize = 0;
            this.bt_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_busca.Image = global::Pilates_CS.Properties.Resources.busca_pac;
            this.bt_busca.Location = new System.Drawing.Point(140, 86);
            this.bt_busca.Name = "bt_busca";
            this.bt_busca.Size = new System.Drawing.Size(123, 68);
            this.bt_busca.TabIndex = 4;
            this.bt_busca.UseVisualStyleBackColor = false;
            this.bt_busca.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_novoPac
            // 
            this.bt_novoPac.BackColor = System.Drawing.Color.Transparent;
            this.bt_novoPac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_novoPac.FlatAppearance.BorderSize = 0;
            this.bt_novoPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novoPac.Image = global::Pilates_CS.Properties.Resources.add_pac;
            this.bt_novoPac.Location = new System.Drawing.Point(34, 86);
            this.bt_novoPac.Name = "bt_novoPac";
            this.bt_novoPac.Size = new System.Drawing.Size(100, 68);
            this.bt_novoPac.TabIndex = 3;
            this.bt_novoPac.UseVisualStyleBackColor = false;
            this.bt_novoPac.Click += new System.EventHandler(this.bt_novoPac_Click);
            // 
            // bt_fecha
            // 
            this.bt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fecha.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_fecha.Location = new System.Drawing.Point(1004, 425);
            this.bt_fecha.Name = "bt_fecha";
            this.bt_fecha.Size = new System.Drawing.Size(105, 37);
            this.bt_fecha.TabIndex = 15;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // fm_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1144, 488);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.bt_busca);
            this.Controls.Add(this.bt_novoPac);
            this.Controls.Add(this.label1);
            this.Name = "fm_paciente";
            this.Opacity = 0.1D;
            this.Text = "paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_novoPac;
        private System.Windows.Forms.Button bt_busca;
        private System.Windows.Forms.Button bt_fecha;
    }
}