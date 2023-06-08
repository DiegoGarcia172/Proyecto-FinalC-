using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
    public partial class FrmConsultaBanxico : Form
    {
        private const string ApiBaseUrl = "https://www.banxico.org.mx/SieAPIRest/service/v1";
        string token = "8c68310ad5a69f27cb9fc10dae1884231f74bfe80d2c346d3dbc08bb27cc40c8";
        //SF43718
        public FrmConsultaBanxico()
        {
            InitializeComponent();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DTPInicio.Value;
            DateTime fechaFin = DTPFin.Value;
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.");
                return;
            }
            string apiUrl = $"{ApiBaseUrl}/series/{TxtSerie.Text.Trim()}/datos/{fechaInicio.ToString("yyyy-MM-dd")}/{fechaFin.ToString("yyyy-MM-dd")}?token={token.Trim()}";
            try
            {
                using (WebClient client = new WebClient())
                {
                    string response = client.DownloadString(apiUrl);
                    JObject jsonResponse = JObject.Parse(response);
                    JArray data = (JArray)jsonResponse["bmx"]["series"][0]["datos"];
                    StringBuilder formattedResponse = new StringBuilder();
                    foreach (JObject item in data)
                    {
                        formattedResponse.AppendLine($"Fecha: {item["fecha"]}, Valor: {item["dato"]}");
                    }
                    List<DateTime> fechas = new List<DateTime>();
                    List<double> valores = new List<double>();
                    foreach (JObject item in data)
                    {
                        DateTime fecha = DateTime.Parse(item["fecha"].ToString());
                        double valor = double.Parse(item["dato"].ToString());
                        fechas.Add(fecha);
                        valores.Add(valor);
                    }
                    LblRespuesta.Text = formattedResponse.ToString();
                    ChConsulta.Series[0].Points.DataBindXY(fechas, valores);
                }
                
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Error al realizar la consulta a la API: {ex.Message}");
            }
        }
    }
}

