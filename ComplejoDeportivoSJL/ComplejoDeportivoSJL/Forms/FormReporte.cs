using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ComplejoDeportivoSJL.Forms
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
            comboBoxPeriodoR.SelectedIndex = 0;
        }

        private void buttonGenerarR_Click(object sender, EventArgs e)
        {
            dataGridViewReporte.Rows.Clear();
            dataGridViewReporte.DataSource = null;
            DateTime FechaActual = DateTime.Today;
            DateTime Fecha;
            double Total = 0;
            StreamReader Datos = new StreamReader("BD.txt", true);

            if (comboBoxPeriodoR.Text == "Dia")
            {                
                string[] campos = null;
                string registro = Datos.ReadLine();
                List<List<string>> lista = new List<List<string>>();
                string dato;
                while (registro != null)
                {
                    //--dividir el registro en campos y mostrarlo
                    campos = registro.Split(new char[] { ',', ';', '-', '$' }, 9);
                    //Fecha = DateTime.ParseExact(campos[4], "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    Fecha = Convert.ToDateTime(campos[4]);
                    List<string> lista2 = new List<string>();
                    //MessageBox.Show(FechaActual.ToString() + Fecha.ToString());
                    if (Fecha.Day == FechaActual.Day && Fecha.Month == FechaActual.Month && Fecha.Year == FechaActual.Year)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            dato = campos[i];
                            lista2.Add(dato);
                        }
                        lista.Add(lista2);

                        Total += Int32.Parse(campos[8]);
                    }
                    registro = Datos.ReadLine();
                }
                for (int k = 0; k < lista.Count(); k++)
                {
                    dataGridViewReporte.Rows.Add(lista[k][0], lista[k][4], lista[k][5], lista[k][6], "S/ " + lista[k][8]);
                }
                textBoxTotal.Text = Total.ToString();
            }
            else if (comboBoxPeriodoR.Text == "Mes")
            {
                string[] campos = null;
                string registro = Datos.ReadLine();
                List<List<string>> lista = new List<List<string>>();
                string dato;
                while (registro != null)
                {
                    //--dividir el registro en campos y mostrarlo
                    campos = registro.Split(new char[] { ',', ';', '-', '$' }, 9);
                    //Fecha = DateTime.ParseExact(campos[4], "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    Fecha = Convert.ToDateTime(campos[4]);
                    List<string> lista2 = new List<string>();
                    if (Fecha.Month == FechaActual.Month && Fecha.Year == FechaActual.Year)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            dato = campos[i];
                            lista2.Add(dato);
                        }
                        lista.Add(lista2);

                        Total += Int32.Parse(campos[8]);
                    }
                    registro = Datos.ReadLine();
                }
                for (int k = 0; k < lista.Count(); k++)
                {
                    dataGridViewReporte.Rows.Add(lista[k][0], lista[k][4], lista[k][5], lista[k][6], "S/ " + lista[k][8]);
                }
                textBoxTotal.Text = Total.ToString();
            }
            else if (comboBoxPeriodoR.Text == "Año")
            {
                string[] campos = null;
                string registro = Datos.ReadLine();
                List<List<string>> lista = new List<List<string>>();
                string dato;
                while (registro != null)
                {
                    //--dividir el registro en campos y mostrarlo
                    campos = registro.Split(new char[] { ',', ';', '-', '$' }, 9);
                    //Fecha = DateTime.ParseExact(campos[4], "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    Fecha = Convert.ToDateTime(campos[4]);
                    List<string> lista2 = new List<string>();
                    if (Fecha.Year == FechaActual.Year)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            dato = campos[i];
                            lista2.Add(dato);
                        }
                        lista.Add(lista2);

                        Total += Int32.Parse(campos[8]);
                    }
                    registro = Datos.ReadLine();
                }
                for (int k = 0; k < lista.Count(); k++)
                {
                    dataGridViewReporte.Rows.Add(lista[k][0], lista[k][4], lista[k][5], lista[k][6], "S/ "+lista[k][8]);
                }
                textBoxTotal.Text = Total.ToString();
            }
            Datos.Close();
        }
    }
}
