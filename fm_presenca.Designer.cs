namespace Pilates_CS
{
    partial class fm_presenca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_presenca));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_fecha = new System.Windows.Forms.Button();
            this.bt_manual = new System.Windows.Forms.Button();
            this.bt_digital = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Presença";
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
            this.bt_fecha.TabIndex = 16;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // bt_manual
            // 
            this.bt_manual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_manual.Image = ((System.Drawing.Image)(resources.GetObject("bt_manual.Image")));
            this.bt_manual.Location = new System.Drawing.Point(150, 81);
            this.bt_manual.Name = "bt_manual";
            this.bt_manual.Size = new System.Drawing.Size(100, 72);
            this.bt_manual.TabIndex = 18;
            this.bt_manual.UseVisualStyleBackColor = true;
            this.bt_manual.Click += new System.EventHandler(this.bt_manual_Click);
            // 
            // bt_digital
            // 
            this.bt_digital.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_digital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_digital.Image = ((System.Drawing.Image)(resources.GetObject("bt_digital.Image")));
            this.bt_digital.Location = new System.Drawing.Point(22, 81);
            this.bt_digital.Name = "bt_digital";
            this.bt_digital.Size = new System.Drawing.Size(100, 72);
            this.bt_digital.TabIndex = 17;
            this.bt_digital.UseVisualStyleBackColor = true;
            // 
            // fm_presenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1144, 488);
            this.Controls.Add(this.bt_manual);
            this.Controls.Add(this.bt_digital);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_presenca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_presenca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_fecha;
        private System.Windows.Forms.Button bt_digital;
        private System.Windows.Forms.Button bt_manual;
    }
}