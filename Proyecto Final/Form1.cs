using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void BtnGraficas_Click(object sender, EventArgs e)
        {
            FrmGraficas frm = new FrmGraficas();
            frm.Show();
        }
        private void BtnLecturadeArchivos_Click(object sender, EventArgs e)
        {
            FrmLectura frm = new FrmLectura();
            frm.Show();
        }
        private void BtnTablasJS_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos HTML (*.html;*.htm)|*.html;*.htm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al abrir el archivo: " + ex.Message);
                }
            }
        }
        private void BtnTreeView_Click(object sender, EventArgs e)
        {
            FrmTreeview frm = new FrmTreeview();
            frm.Show();
        }
        private void BtnConsultaAPIBanxico_Click(object sender, EventArgs e)
        {
            FrmConsultaBanxico frm = new FrmConsultaBanxico();
            frm.Show();
        }
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
