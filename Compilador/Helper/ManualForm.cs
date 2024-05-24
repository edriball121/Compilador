using System.IO;
using System.Windows.Forms;

namespace Compilador.Helper
{
    public partial class ManualForm : Form
    {
        public ManualForm(string filePath)
        {
            InitializeComponent();

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                // Leer el contenido del archivo
                string fileContent = File.ReadAllText(filePath);

                // Mostrar el contenido en el control de texto
                wb_help_text.Navigate(filePath);
            }
            else
            {
                MessageBox.Show("El archivo no existe: " + filePath);
            }

        }
    }
}
