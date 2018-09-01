namespace Pilates_CS
{
    partial class Fm_agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_agenda));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_fecha = new System.Windows.Forms.Button();
            this.bt_novo_age = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agenda";
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
            this.bt_fecha.TabIndex = 17;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // bt_novo_age
            // 
            this.bt_novo_age.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_novo_age.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novo_age.Image = ((System.Drawing.Image)(resources.GetObject("bt_novo_age.Image")));
            this.bt_novo_age.Location = new System.Drawing.Point(34, 86);
            this.bt_novo_age.Name = "bt_novo_age";
            this.bt_novo_age.Size = new System.Drawing.Size(111, 66);
            this.bt_novo_age.TabIndex = 25;
            this.bt_novo_age.UseVisualStyleBackColor = true;
            this.bt_novo_age.Click += new System.EventHandler(this.bt_novo_age_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Image = ((System.Drawing.Image)(resources.GetObject("bt_editar.Image")));
            this.bt_editar.Location = new System.Drawing.Point(151, 86);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(111, 66);
            this.bt_editar.TabIndex = 26;
            this.bt_editar.UseVisualStyleBackColor = true;
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_visualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_visualizar.Image")));
            this.bt_visualizar.Location = new System.Drawing.Point(268, 86);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(138, 66);
            this.bt_visualizar.TabIndex = 27;
            this.bt_visualizar.UseVisualStyleBackColor = true;
            this.bt_visualizar.Click += new System.EventHandler(this.bt_visualizar_Click);
            // 
            // Fm_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1144, 488);
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_novo_age);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fm_agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_fecha;
        private System.Windows.Forms.Button bt_novo_age;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_visualizar;
    }
}