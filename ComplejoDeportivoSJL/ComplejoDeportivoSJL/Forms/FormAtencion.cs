using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComplejoDeportivoSJL.Forms
{
    public partial class FormAtencion : Form
    {
        public FormAtencion()
        {
            InitializeComponent();
            comboBoxDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeporte.SelectedIndex = 0;
        }

        private void Limpiar()
        {
            textBoxDNI.Clear();
            textBoxNombres.Clear();
            textBoxApellidos.Clear();
            comboBoxDeporte.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
            comboBoxHoraInicio.SelectedIndex = 0;
            comboBoxHoraFin.SelectedIndex = 0;
            textBoxCPersonas.Clear();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            int TarifaFutsal = 0;
            int TarifaBasket = 0;
            int TarifaVoley = 0;
            int TarifaTennis = 0;
            StreamReader archivoTarifa = new StreamReader("Tarifas.txt", true);
            string[] campos = null;
            string registro = archivoTarifa.ReadLine();
            if (registro != null)
            {
                campos = registro.Split(new char[] { ',' }, 6);
                TarifaFutsal = Int32.Parse(campos[0]);
                TarifaBasket = Int32.Parse(campos[1]);
                TarifaVoley = Int32.Parse(campos[2]);
                TarifaTennis = Int32.Parse(campos[3]);
            }

            int Hinicio = int.Parse(comboBoxHoraInicio.Text);
            int Hfin = int.Parse(comboBoxHoraFin.Text);
            if (Hinicio >= Hfin)
            {
                errorHora.SetError(comboBoxHoraFin, "La hora de fin debe ser mayor a la hora de inicio");
                comboBoxHoraFin.Focus();
            }
            else
            {
                double TotalPagar;
                int HTotal = Hfin - Hinicio;
                if (comboBoxDeporte.Text == "Futsal") { TotalPagar = HTotal * TarifaFutsal; }
                else if (comboBoxDeporte.Text == "Basket") { TotalPagar = HTotal * TarifaBasket; }
                else if (comboBoxDeporte.Text == "Voley") { TotalPagar = HTotal * TarifaVoley; }
                else { TotalPagar = HTotal * TarifaTennis; }
                StreamWriter archivo = new StreamWriter("BD.txt", true);
                archivo.WriteLine($"{textBoxDNI.Text.ToUpper()},{textBoxApellidos.Text.ToUpper()},{textBoxNombres.Text.ToUpper()},{comboBoxDeporte.Text.ToUpper()},{dateTimePicker.Text.ToUpper()},{comboBoxHoraInicio.Text.ToUpper()},{comboBoxHoraFin.Text.ToUpper()},{textBoxCPersonas.Text.ToUpper()},{TotalPagar}");
                //cerrar archivo
                archivo.Close();
                MessageBox.Show("RESUMEN" +
                    "\nUsuario: " + textBoxApellidos.Text + " " + textBoxNombres.Text +
                    "\nDeporte: " + comboBoxDeporte.Text +
                    "\nFecha: " + dateTimePicker.Text +
                    "\nHorario: " + comboBoxHoraInicio.Text + ":00 hrs a " + comboBoxHoraFin.Text + ":00 hrs" +
                    "\nTotal a Pagar: S/" + TotalPagar.ToString());
                Limpiar();
            }
            archivoTarifa.Close();
        }
    }
}
