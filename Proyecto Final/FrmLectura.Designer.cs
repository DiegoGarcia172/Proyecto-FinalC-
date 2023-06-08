namespace Proyecto_Final
{
    partial class FrmLectura
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnExportarCSV = new System.Windows.Forms.Button();
            this.ExportarExcel = new System.Windows.Forms.Button();
            this.BtnExportarTXT = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(628, 14);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 33);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DGV1
            // 
            this.DGV1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(16, 55);
            this.DGV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.Size = new System.Drawing.Size(692, 401);
            this.DGV1.TabIndex = 10;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(16, 15);
            this.BtnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(73, 33);
            this.BtnCargar.TabIndex = 11;
            this.BtnCargar.Text = "Cargar ";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnExportarCSV
            // 
            this.BtnExportarCSV.Location = new System.Drawing.Point(97, 15);
            this.BtnExportarCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExportarCSV.Name = "BtnExportarCSV";
            this.BtnExportarCSV.Size = new System.Drawing.Size(109, 33);
            this.BtnExportarCSV.TabIndex = 12;
            this.BtnExportarCSV.Text = "Exportar CSV";
            this.BtnExportarCSV.UseVisualStyleBackColor = true;
            this.BtnExportarCSV.Click += new System.EventHandler(this.BtnExportarCSV_Click);
            // 
            // ExportarExcel
            // 
            this.ExportarExcel.Location = new System.Drawing.Point(222, 15);
            this.ExportarExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportarExcel.Name = "ExportarExcel";
            this.ExportarExcel.Size = new System.Drawing.Size(124, 33);
            this.ExportarExcel.TabIndex = 14;
            this.ExportarExcel.Text = "Exportar Excel";
            this.ExportarExcel.UseVisualStyleBackColor = true;
            this.ExportarExcel.Click += new System.EventHandler(this.ExportarExcel_Click);
            // 
            // BtnExportarTXT
            // 
            this.BtnExportarTXT.Location = new System.Drawing.Point(354, 15);
            this.BtnExportarTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExportarTXT.Name = "BtnExportarTXT";
            this.BtnExportarTXT.Size = new System.Drawing.Size(109, 33);
            this.BtnExportarTXT.TabIndex = 15;
            this.BtnExportarTXT.Text = "Exportar TXT";
            this.BtnExportarTXT.UseVisualStyleBackColor = true;
            this.BtnExportarTXT.Click += new System.EventHandler(this.BtnExportarTXT_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(471, 15);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(72, 33);
            this.BtnLimpiar.TabIndex = 16;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmLectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 476);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnExportarTXT);
            this.Controls.Add(this.ExportarExcel);
            this.Controls.Add(this.BtnExportarCSV);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.BtnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLectura";
            this.Text = "FrmLectura";
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnExportarCSV;
        private System.Windows.Forms.Button ExportarExcel;
        private System.Windows.Forms.Button BtnExportarTXT;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}