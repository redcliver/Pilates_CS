namespace Pilates_CS
{
    partial class fm_visualizar
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
            this.bt_fecha = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.agenda = new Pilates_CS.agenda();
            this.dataSet1 = new Pilates_CS.DataSet1();
            this.dg_agenda = new System.Windows.Forms.DataGridView();
            this.dt_data = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "Visualizar agenda";
            // 
            // bt_fecha
            // 
            this.bt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fecha.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_fecha.Location = new System.Drawing.Point(530, 425);
            this.bt_fecha.Name = "bt_fecha";
            this.bt_fecha.Size = new System.Drawing.Size(105, 37);
            this.bt_fecha.TabIndex = 18;
            this.bt_fecha.Text = "Fechar";
            this.bt_fecha.UseVisualStyleBackColor = false;
            this.bt_fecha.Click += new System.EventHandler(this.bt_fecha_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(128)))));
            this.bt_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.bt_buscar.Location = new System.Drawing.Point(530, 113);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(105, 37);
            this.bt_buscar.TabIndex = 21;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // agenda
            // 
            this.agenda.DataSetName = "agenda";
            this.agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dg_agenda
            // 
            this.dg_agenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dg_agenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_agenda.Location = new System.Drawing.Point(22, 87);
            this.dg_agenda.Name = "dg_agenda";
            this.dg_agenda.Size = new System.Drawing.Size(353, 375);
            this.dg_agenda.TabIndex = 23;
            // 
            // dt_data
            // 
            this.dt_data.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_data.Location = new System.Drawing.Point(415, 87);
            this.dt_data.Name = "dt_data";
            this.dt_data.Size = new System.Drawing.Size(220, 20);
            this.dt_data.TabIndex = 22;
            // 
            // fm_visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(670, 488);
            this.Controls.Add(this.dg_agenda);
            this.Controls.Add(this.dt_data);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.bt_fecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_visualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_visualizar";
            this.Load += new System.EventHandler(this.fm_visualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_fecha;
        private System.Windows.Forms.Button bt_buscar;
        private agenda agenda;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dg_agenda;
        private System.Windows.Forms.DateTimePicker dt_data;
    }
}