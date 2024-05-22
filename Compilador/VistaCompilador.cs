using System;
using System.IO;
using System.Windows.Forms;

namespace Compilador
{
    public partial class VistaCompilador : Form
    {
        public VistaCompilador()
        {
            InitializeComponent();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Seleccionar un archivo de texto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    lbl_entry.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al leer el archivo: " + ex.Message);
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lbl_entry.Clear();
        }

        private void btn_compile_Click(object sender, EventArgs e)
        {
            lbl_entry.Text = "Compilando....";
        }
    }
}
