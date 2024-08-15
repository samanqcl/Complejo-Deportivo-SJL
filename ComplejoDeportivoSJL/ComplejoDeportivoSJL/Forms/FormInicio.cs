using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComplejoDeportivoSJL.Forms
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            StreamReader archivo = new StreamReader("Tarifas.txt", true);
            string[] campos = null;
            string registro = archivo.ReadLine();
            if (registro != null)
            {
                //--dividir el registro en campos y mostrarlo
                campos = registro.Split(new char[] {','}, 4);
                textBoxTarifaFutsal.Text = campos[0];
                textBoxTarifaBasket.Text = campos[1];
                textBoxTarifaVoley.Text = campos[2];
                textBoxTarifaTennis.Text = campos[3];
            }
            archivo.Close();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            StreamWriter Temporal = File.CreateText("Temporal.txt");
            Temporal.WriteLine($"{textBoxTarifaFutsal.Text.ToUpper()},{textBoxTarifaBasket.Text.ToUpper()},{textBoxTarifaVoley.Text.ToUpper()},{textBoxTarifaTennis.Text.ToUpper()}");
            //cerrar archivo
            Temporal.Close();
            File.Delete("Tarifas.txt");
            File.Move("Temporal.txt", "Tarifas.txt");
            MessageBox.Show("MODIFICACIÓN EXITOSA!");
        }
    }
}
