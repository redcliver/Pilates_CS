namespace Pilates_CS
{
    partial class fm_caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_caixa));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_fecha = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_retirada = new System.Windows.Forms.Button();
            this.bt_entrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 57);
            this.label1.TabIndex = 23;
            this.label1.Text = "Caixa";
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
            this.bt_fecha.TabIndex = 30;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(286, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 66);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_retirada
            // 
            this.bt_retirada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_retirada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_retirada.Location = new System.Drawing.Point(151, 86);
            this.bt_retirada.Name = "bt_retirada";
            this.bt_retirada.Size = new System.Drawing.Size(129, 66);
            this.bt_retirada.TabIndex = 25;
            this.bt_retirada.UseVisualStyleBackColor = true;
            this.bt_retirada.Click += new System.EventHandler(this.bt_retirada_Click);
            // 
            // bt_entrada
            // 
            this.bt_entrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_entrada.Image = ((System.Drawing.Image)(resources.GetObject("bt_entrada.Image")));
            this.bt_entrada.Location = new System.Drawing.Point(34, 86);
            this.bt_entrada.Name = "bt_entrada";
            this.bt_entrada.Size = new System.Drawing.Size(111, 66);
            this.bt_entrada.TabIndex = 24;
            this.bt_entrada.UseVisualStyleBackColor = true;
            this.bt_entrada.Click += new System.EventHandler(this.bt_entrada_Click);
            // 
            // fm_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1144, 400);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_retirada);
            this.Controls.Add(this.bt_entrada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_retirada;
        private System.Windows.Forms.Button bt_entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_fecha;
    }
}