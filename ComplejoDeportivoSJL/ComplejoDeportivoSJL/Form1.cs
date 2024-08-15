using System.IO;

namespace ComplejoDeportivoSJL
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            bool fileExistTarifa = File.Exists("Tarifas.txt");
            if (!fileExistTarifa)
            {
                StreamWriter archivotarifas = new StreamWriter("Tarifas.txt", true);
                archivotarifas.WriteLine($"{0},{0},{0},{0}");
                archivotarifas.Close();
            }
            bool fileExistDatos = File.Exists("BD.txt");
            if (!fileExistDatos)
            {
                StreamWriter archivoBD = new StreamWriter("BD.txt", true);
                archivoBD.Close();
            }
        }

        private void OpenChildProcess(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(childForm);
            this.panelContenido.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void buttonAtencion_Click(object sender, EventArgs e)
        {
            OpenChildProcess(new Forms.FormAtencion(), sender);
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            OpenChildProcess(new Forms.FormReporte(), sender);
        }

        private void buttonEstadisticas_Click(object sender, EventArgs e)
        {
            OpenChildProcess(new Forms.FormEstadisticas(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildProcess(new Forms.FormInicio(), sender);
        }
    }
}