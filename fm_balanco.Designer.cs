namespace Pilates_CS
{
    partial class fm_balanco
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
            this.bt_mensal = new System.Windows.Forms.Button();
            this.bt_diario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_anual = new System.Windows.Forms.Button();
            this.bt_fecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_mensal
            // 
            this.bt_mensal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_mensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mensal.Location = new System.Drawing.Point(151, 86);
            this.bt_mensal.Name = "bt_mensal";
            this.bt_mensal.Size = new System.Drawing.Size(129, 66);
            this.bt_mensal.TabIndex = 11;
            this.bt_mensal.UseVisualStyleBackColor = true;
            this.bt_mensal.Click += new System.EventHandler(this.bt_mensal_Click);
            // 
            // bt_diario
            // 
            this.bt_diario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_diario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_diario.Location = new System.Drawing.Point(34, 86);
            this.bt_diario.Name = "bt_diario";
            this.bt_diario.Size = new System.Drawing.Size(111, 66);
            this.bt_diario.TabIndex = 10;
            this.bt_diario.UseVisualStyleBackColor = true;
            this.bt_diario.Click += new System.EventHandler(this.bt_diario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "Balanço";
            // 
            // bt_anual
            // 
            this.bt_anual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_anual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_anual.Location = new System.Drawing.Point(286, 86);
            this.bt_anual.Name = "bt_anual";
            this.bt_anual.Size = new System.Drawing.Size(129, 66);
            this.bt_anual.TabIndex = 12;
            this.bt_anual.UseVisualStyleBackColor = true;
            this.bt_anual.Click += new System.EventHandler(this.bt_anual_Click);
            // 
            // bt_fecha
            // 
            this.bt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fecha.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_fecha.Location = new System.Drawing.Point(1007, 335);
            this.bt_fecha.Name = "bt_fecha";
            this.bt_fecha.Size = new System.Drawing.Size(105, 37);
            this.bt_fecha.TabIndex = 19;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // fm_balanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1144, 400);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.bt_anual);
            this.Controls.Add(this.bt_mensal);
            this.Controls.Add(this.bt_diario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_balanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_balanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_mensal;
        private System.Windows.Forms.Button bt_diario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_anual;
        private System.Windows.Forms.Button bt_fecha;
    }
}