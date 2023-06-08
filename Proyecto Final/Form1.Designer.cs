namespace Proyecto_Final
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGraficas = new System.Windows.Forms.Button();
            this.BtnLecturadeArchivos = new System.Windows.Forms.Button();
            this.BtnTreeView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnConsultaAPIBanxico = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGraficas
            // 
            this.BtnGraficas.Location = new System.Drawing.Point(73, 101);
            this.BtnGraficas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGraficas.Name = "BtnGraficas";
            this.BtnGraficas.Size = new System.Drawing.Size(184, 70);
            this.BtnGraficas.TabIndex = 0;
            this.BtnGraficas.Text = "Graficas";
            this.BtnGraficas.UseVisualStyleBackColor = true;
            this.BtnGraficas.Click += new System.EventHandler(this.BtnGraficas_Click);
            // 
            // BtnLecturadeArchivos
            // 
            this.BtnLecturadeArchivos.Location = new System.Drawing.Point(73, 194);
            this.BtnLecturadeArchivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLecturadeArchivos.Name = "BtnLecturadeArchivos";
            this.BtnLecturadeArchivos.Size = new System.Drawing.Size(184, 70);
            this.BtnLecturadeArchivos.TabIndex = 1;
            this.BtnLecturadeArchivos.Text = "Lectura de archivos";
            this.BtnLecturadeArchivos.UseVisualStyleBackColor = true;
            this.BtnLecturadeArchivos.Click += new System.EventHandler(this.BtnLecturadeArchivos_Click);
            // 
            // BtnTreeView
            // 
            this.BtnTreeView.Location = new System.Drawing.Point(73, 294);
            this.BtnTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTreeView.Name = "BtnTreeView";
            this.BtnTreeView.Size = new System.Drawing.Size(184, 70);
            this.BtnTreeView.TabIndex = 2;
            this.BtnTreeView.Text = "TreeView";
            this.BtnTreeView.UseVisualStyleBackColor = true;
            this.BtnTreeView.Click += new System.EventHandler(this.BtnTreeView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proyecto en C#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hace un treeview donde muestra un texto CSV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Visualiza los archivos  CSV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Crea graficas a partir de un CSV";
            // 
            // BtnConsultaAPIBanxico
            // 
            this.BtnConsultaAPIBanxico.Location = new System.Drawing.Point(73, 394);
            this.BtnConsultaAPIBanxico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConsultaAPIBanxico.Name = "BtnConsultaAPIBanxico";
            this.BtnConsultaAPIBanxico.Size = new System.Drawing.Size(184, 70);
            this.BtnConsultaAPIBanxico.TabIndex = 22;
            this.BtnConsultaAPIBanxico.Text = "Consulta a API Banxico";
            this.BtnConsultaAPIBanxico.UseVisualStyleBackColor = true;
            this.BtnConsultaAPIBanxico.Click += new System.EventHandler(this.BtnConsultaAPIBanxico_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 374);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Consulta a la API Banxico";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(301, 61);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(61, 59);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(386, 472);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnConsultaAPIBanxico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTreeView);
            this.Controls.Add(this.BtnLecturadeArchivos);
            this.Controls.Add(this.BtnGraficas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGraficas;
        private System.Windows.Forms.Button BtnLecturadeArchivos;
        private System.Windows.Forms.Button BtnTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnConsultaAPIBanxico;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnSalir;
    }
}

