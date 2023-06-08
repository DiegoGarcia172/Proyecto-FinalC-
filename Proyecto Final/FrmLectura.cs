using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;

namespace Proyecto_Final
{
    public partial class FrmLectura : Form
    {
        public FrmLectura()
        {
            InitializeComponent();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvFilePath = openFileDialog.FileName;
                LoadCSVFile(csvFilePath);
            }
        }
        private void LoadCSVFile(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    DataTable dt = new DataTable();
                    bool isFirstRow = true;

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split('|');

                        if (isFirstRow)
                        {
                            foreach (var header in values)
                            {
                                dt.Columns.Add(header);
                            }

                            isFirstRow = false;
                        }
                        else
                        {
                            dt.Rows.Add(values);
                        }
                    }

                    DGV1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
            MessageBox.Show("Archivo Creado Correctamente");
            DGV1.Columns.Clear();
        }
        private void BtnExportarCSV_Click(object sender, EventArgs e)
        {
            ExportarCSV();
        }
        private void ExportarCSV()
        {
            SaveFileDialog dlGuardar = new SaveFileDialog();
            dlGuardar.Filter = "Fichero CSV (*.csv)|*.csv";
            dlGuardar.FileName = "Datos_sqlite";
            dlGuardar.Title = "Exportar a CSV";
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();
                for (int i = 0; i < DGV1.Columns.Count; i++)
                {
                    if (i == DGV1.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            DGV1.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\";",
                            DGV1.Columns[i].HeaderText));
                    }
                }
                csvMemoria.AppendLine();
                for (int m = 0; m < DGV1.Rows.Count; m++)
                {
                    for (int n = 0; n < DGV1.Columns.Count; n++)
                    {
                        if (n == DGV1.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"",
                                 DGV1.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("\"{0}\";",
                                DGV1.Rows[m].Cells[n].Value));
                        }
                    }
                    csvMemoria.AppendLine();
                }
                StreamWriter sw =
                    new StreamWriter(dlGuardar.FileName, false,
                      Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }
            MessageBox.Show("Archivo Creado Correctamente");
            DGV1.Columns.Clear();
        }
        private void ExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(DGV1);
        }
        private void ExportarTXT()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in DGV1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append("|");
                }
                sb.AppendLine();
            }
            string outputFile = "ruta_del_archivo.txt"; 
            File.WriteAllText(outputFile, sb.ToString());
            MessageBox.Show("Exportación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(outputFile);
        }
        private void BtnExportarTXT_Click(object sender, EventArgs e)
        {
            ExportarTXT();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DGV1.Columns.Clear();
        }
    }
}
    

