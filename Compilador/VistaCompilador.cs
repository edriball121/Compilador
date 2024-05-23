using System;
using System.IO;
using System.Windows.Forms;
using Irony.Parsing;

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
                    txt_entry.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al leer el archivo: " + ex.Message);
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_entry.Clear();
        }

        private void btn_compile_Click(object sender, EventArgs e)
        {
            string input = txt_entry.Text;

            // Crear el analizador léxico y sintáctico
            var grammar = new Gramatic();
            var parser = new Parser(grammar);

            // Realizar el análisis
            var parseTree = parser.Parse(input);

            // Mostrar los tokens léxicos
            tb_lexico.Rows.Clear();
            foreach (var token in parseTree.Tokens)
            {
                txt_lexico.AppendText($"Token: {token.Text}, Tipo: {token.Terminal.Name}\n");
            }

            // Verificar si hay errores sintácticos
            if (parseTree.HasErrors())
            {
                txt_semantico.Clear();
                txt_semantico.AppendText("Errores de análisis sintáctico encontrados:\n");
                foreach (var message in parseTree.ParserMessages)
                {
                    txt_semantico.AppendText($"{message}\n");
                }
            }
            else
            {
                txt_semantico.Text = "Análisis sintáctico completado exitosamente.";
            }
        }

        private void btn_limpiar_salias_Click(object sender, EventArgs e)
        {
            tb_lexico.Rows.Clear();
            txt_semantico.Clear();
        }
    }
}
