namespace Proyecto_Final
{
    partial class FrmGraficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnSelArchivo = new System.Windows.Forms.Button();
            this.ChGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(366, 4);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(86, 44);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnSelArchivo
            // 
            this.BtnSelArchivo.Location = new System.Drawing.Point(16, 4);
            this.BtnSelArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSelArchivo.Name = "BtnSelArchivo";
            this.BtnSelArchivo.Size = new System.Drawing.Size(139, 44);
            this.BtnSelArchivo.TabIndex = 8;
            this.BtnSelArchivo.Text = "Seleccionar archivo ";
            this.BtnSelArchivo.UseVisualStyleBackColor = true;
            this.BtnSelArchivo.Click += new System.EventHandler(this.BtnSelArchivo_Click);
            // 
            // ChGrafica
            // 
            chartArea1.Name = "ChartArea1";
            this.ChGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChGrafica.Legends.Add(legend1);
            this.ChGrafica.Location = new System.Drawing.Point(49, 76);
            this.ChGrafica.Margin = new System.Windows.Forms.Padding(4);
            this.ChGrafica.Name = "ChGrafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChGrafica.Series.Add(series1);
            this.ChGrafica.Size = new System.Drawing.Size(400, 369);
            this.ChGrafica.TabIndex = 9;
            this.ChGrafica.Text = "chart1";
            this.ChGrafica.Click += new System.EventHandler(this.ChGrafica_Click);
            // 
            // FrmGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 460);
            this.Controls.Add(this.ChGrafica);
            this.Controls.Add(this.BtnSelArchivo);
            this.Controls.Add(this.BtnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGraficas";
            this.Text = "FrmGraficas";
            ((System.ComponentModel.ISupportInitialize)(this.ChGrafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnSelArchivo;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChGrafica;
    }
}