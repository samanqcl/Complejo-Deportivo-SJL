using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplejoDeportivoSJL.Forms
{
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
            comboBoxPeriodoE.SelectedIndex = 0;
        }

        private void buttonGenerarE_Click(object sender, EventArgs e)
        {
            DateTime FechaActual = DateTime.Today;
            DateTime Fecha;
            int CTotal;
            int CFutsal = 0;
            int CBasket = 0;
            int CVoley = 0;
            int CTennis = 0;
            StreamReader Datos = new StreamReader("BD.txt", true);

            if (comboBoxPeriodoE.Text == "Dia")
            {
                string[] campos = null;
                string registro = Datos.ReadLine();
                while (registro != null)
                {
                    //--dividir el registro en campos y mostrarlo
                    campos = registro.Split(new char[] { ',', ';', '-', '$' }, 9);
                    //Fecha = DateTime.ParseExact(campos[4], "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    Fecha = Convert.ToDateTime(campos[4]);
                    //MessageBox.Show(FechaActual.ToString() + Fecha.ToString());
                    if (Fecha.Day == FechaActual.Day && Fecha.Month == FechaActual.Month && Fecha.Year == FechaActual.Year)
                    {
                        if (campos[3] == "FUTSAL") { CFutsal += Int32.Parse(campos[7]); }
                        else if (campos[3] == "BASKET") { CBasket += Int32.Parse(campos[7]); }
                        else if (campos[3] == "VOLEY") { CVoley += Int32.Parse(campos[7]); }
                        else { CTennis += Int32.Parse(campos[7]); }
                    }
                    registro = Datos.ReadLine();
                }
                CTotal = CFutsal + CBasket + CVoley + CTennis;
                textBoxUFtusal.Text = CFutsal.ToString();
                textBoxUBasket.Text = CBasket.ToString();
                textBoxUVoley.Text = CVoley.ToString();
                textBoxUTennis.Text = CTennis.ToString();
                textBoxUTotal.Text = CTotal.ToString();

                textBoxPFutsal.Text = ((CFutsal * 100) / CTotal).ToString() + " %" ;
                textBoxPBasket.Text = ((CBasket * 100) / CTotal).ToString() + " %" ;
                textBoxPVoley.Text = ((CVoley * 100) / CTotal).ToString() + " %";
                textBoxPTennis.Text = ((CTennis * 100) / CTotal).ToString() + " %";
                textBoxPTotal.Text = "100 % ";
            }
            else if (comboBoxPeriodoE.Text == "Mes")
            {
                string[] campos = null;
                string registro = Datos.ReadLine();
                while (registro != null)
                {
                    //--dividir el registro en campos y mostrarlo
                    campos = registro.Split(new char[] { ',', ';', '-', '$' }, 9);
                    //Fecha = DateTime.ParseExact(campos[4], "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    Fecha = Convert.ToDateTime(campos[4]);
                    if (Fecha.Month == FechaActual.Month && Fecha.Year == FechaActual.Year)
                    {
                        if (campos[3] == "FUTSAL") { CFutsal += Int32.Parse(campos[7]); }
                        else if (campos[3] == "BASKET") { CBasket += Int32.Parse(campos[7]); }
                        else if (campos[3] == "VOLEY") { CVoley += Int32.Parse(campos[7]); }
                        else { CTennis += Int32.Parse(campos[7]); }
                    }
                    registro = Datos.ReadLine();
                }
                CTotal = CFutsal + CBasket + CVoley + CTennis;
                textBoxUFtusal.Text = CFutsal.ToString();
                textBoxUBasket.Text = CBasket.ToString();
                textBoxUVoley.Text = CVoley.ToString();
                textBoxUTennis.Text = CTennis.ToString();
                textBoxUTotal.Text = CTotal.ToString();

                textBoxPFutsal.Text = ((CFutsal * 100) / CTotal).ToString() + " %";
                textBoxPBasket.Text = ((CBasket * 100) / CTotal).ToString() + " %";
                textBoxPVoley.Text = ((CVoley * 100) / CTotal).ToString() + " %";
                textBoxPTennis.Text = ((CTennis * 100) / CTotal).ToString() + " %";
                textBoxPTotal.Text = "100 %";
            }
            else if (comboBoxPeriodoE.Text == "Año")
            {
                string[] campos = null;
                string registro = Datos.ReadLine();
                while (registro != null)
                {
                    //--dividir el registro en campos y mostrarlo
                    campos = registro.Split(new char[] { ',', ';', '-', '$' }, 9);
                    //Fecha = DateTime.ParseExact(campos[4], "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    Fecha = Convert.ToDateTime(campos[4]);
                    if (Fecha.Year == FechaActual.Year)
                    {
                        if (campos[3] == "FUTSAL") { CFutsal += Int32.Parse(campos[7]); }
                        else if (campos[3] == "BASKET") { CBasket += Int32.Parse(campos[7]); }
                        else if (campos[3] == "VOLEY") { CVoley += Int32.Parse(campos[7]); }
                        else { CTennis += Int32.Parse(campos[7]); }
                    }
                    registro = Datos.ReadLine();
                }
                CTotal = CFutsal + CBasket + CVoley + CTennis;
                textBoxUFtusal.Text = CFutsal.ToString();
                textBoxUBasket.Text = CBasket.ToString();
                textBoxUVoley.Text = CVoley.ToString();
                textBoxUTennis.Text = CTennis.ToString();
                textBoxUTotal.Text = CTotal.ToString();

                textBoxPFutsal.Text = ((CFutsal * 100) / CTotal).ToString() + " %";
                textBoxPBasket.Text = ((CBasket * 100) / CTotal).ToString() + " %";
                textBoxPVoley.Text = ((CVoley * 100) / CTotal).ToString() + " %";
                textBoxPTennis.Text = ((CTennis * 100) / CTotal).ToString() + " %";
                textBoxPTotal.Text = "100 %";
            }
            Datos.Close();
        }
    }
}
