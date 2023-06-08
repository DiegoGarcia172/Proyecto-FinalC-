namespace Proyecto_Final
{
    partial class FrmConsultaBanxico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.DTPFin = new System.Windows.Forms.DateTimePicker();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.TxtToken = new System.Windows.Forms.TextBox();
            this.LblToken = new System.Windows.Forms.Label();
            this.ChConsulta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(218, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fin:";
            // 
            // DTPInicio
            // 
            this.DTPInicio.Location = new System.Drawing.Point(64, 73);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(200, 20);
            this.DTPInicio.TabIndex = 3;
            // 
            // DTPFin
            // 
            this.DTPFin.Location = new System.Drawing.Point(64, 102);
            this.DTPFin.Name = "DTPFin";
            this.DTPFin.Size = new System.Drawing.Size(200, 20);
            this.DTPFin.TabIndex = 4;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(189, 128);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(63, 45);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(100, 20);
            this.TxtSerie.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serie:";
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Location = new System.Drawing.Point(60, 169);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(0, 13);
            this.LblRespuesta.TabIndex = 9;
            // 
            // TxtToken
            // 
            this.TxtToken.Location = new System.Drawing.Point(64, 12);
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.Size = new System.Drawing.Size(100, 20);
            this.TxtToken.TabIndex = 10;
            // 
            // LblToken
            // 
            this.LblToken.AutoSize = true;
            this.LblToken.Location = new System.Drawing.Point(12, 13);
            this.LblToken.Name = "LblToken";
            this.LblToken.Size = new System.Drawing.Size(41, 13);
            this.LblToken.TabIndex = 11;
            this.LblToken.Text = "Token:";
            // 
            // ChConsulta
            // 
            chartArea1.Name = "ChartArea1";
            this.ChConsulta.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChConsulta.Legends.Add(legend1);
            this.ChConsulta.Location = new System.Drawing.Point(328, 12);
            this.ChConsulta.Name = "ChConsulta";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChConsulta.Series.Add(series1);
            this.ChConsulta.Size = new System.Drawing.Size(300, 300);
            this.ChConsulta.TabIndex = 12;
            // 
            // FrmConsultaBanxico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChConsulta);
            this.Controls.Add(this.LblToken);
            this.Controls.Add(this.TxtToken);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSerie);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DTPFin);
            this.Controls.Add(this.DTPInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaBanxico";
            this.Text = "FrmConsultaBanxico";
            ((System.ComponentModel.ISupportInitialize)(this.ChConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.DateTimePicker DTPFin;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.TextBox TxtToken;
        private System.Windows.Forms.Label LblToken;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChConsulta;
    }
}