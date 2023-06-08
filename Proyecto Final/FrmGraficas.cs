using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Proyecto_Final
{
    public partial class FrmGraficas : Form
    {
        bool maximizado;
        OpenFileDialog dialogo = new OpenFileDialog();
        public FrmGraficas()
        {
            InitializeComponent();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSelArchivo_Click(object sender, EventArgs e)
        {
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string rutaARCHIVO = dialogo.FileName;
            string renglon;
            StreamReader dr = new StreamReader(rutaARCHIVO, Encoding.GetEncoding(1252));
            string x = "";
            int y = 0;

            while ((renglon = dr.ReadLine()) != null)
            {
                string[] datos = renglon.Split('|');

                if (x != datos[0] && x != "")
                {
                    ChGrafica.Series[0].Points.AddXY(x, y);
                    y = 0;
                }

                x = datos[0];
                y++;
            }

            ChGrafica.Series[0].Points.AddXY(x, y);
            dr.Close();
        }
        private void ChGrafica_Click(object sender, EventArgs e)
        {
            if (maximizado)
            {
                ChGrafica.Location = new Point(436, 12);
                ChGrafica.Height = this.Height;
                ChGrafica.Width = this.Width;
            }
            else
            {
                ChGrafica.Location = new Point(0, 0);
                ChGrafica.Height = this.Height;
                ChGrafica.Width = this.Width;
            }

            maximizado = !maximizado;
        }
    }
}
