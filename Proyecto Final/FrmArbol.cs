using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
    public partial class FrmTreeview : Form
    {
        public FrmTreeview()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable ReadCSV(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] headers = sr.ReadLine().Split('|');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split('|');
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dataRow[i] = rows[i];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }
        private void BuildTreeView(DataTable dataTable)
        {
            treeView1.Nodes.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                TreeNode parentNode = null;

                foreach (DataColumn column in dataTable.Columns)
                {
                    string value = row[column].ToString();

                    if (parentNode == null)
                    {
                        parentNode = treeView1.Nodes.Add(value);
                    }
                    else
                    {
                        parentNode = parentNode.Nodes.Add(value);
                    }
                }
            }

            treeView1.ExpandAll();
        }
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DataTable dataTable = ReadCSV(filePath);
                BuildTreeView(dataTable);
            }
        }
    }
}