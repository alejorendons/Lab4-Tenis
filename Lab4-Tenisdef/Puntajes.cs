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

namespace Lab4_Tenisdef
{
    public partial class Puntajes : Form
    {
       
        public Puntajes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarPuntajesDesdeArchivo();
        }

        private void CargarPuntajesDesdeArchivo()
        {
            FileStream fs1 = new FileStream("Puntajes.txt", FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs1))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] datos = linea.Split(',');
                    dataGridView1.Rows.Add(datos[0], datos[1], datos[2], datos[3]);
                }
            }
            fs1.Close();
        }

        private void Puntajes_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada del DateTimePicker
            string fecha = dateTimePicker1.Value.ToShortDateString(); // Convierte la fecha a una cadena en formato corto

            // Agregar al DataGridView
            dataGridView1.Rows.Add(fecha, textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text);

            // Agregar al archivo
            using (StreamWriter writer = new StreamWriter("Puntajes.txt", true)) // true para agregar al archivo existente
            {
                writer.WriteLine($"{fecha},{textBox1.Text},{textBox3.Text},{textBox2.Text},{textBox4.Text}");
            }

            // Limpiar TextBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void ConfigurarDataGridView()
        {

            // Asegúrate de que las columnas se agreguen antes de cargar los datos
            dataGridView1.Columns.Add("columna5", "Fecha");
            dataGridView1.Columns.Add("columna1", "Nombre Jugador 1");
            dataGridView1.Columns.Add("columna2", "Puntaje Jugador 1");
            dataGridView1.Columns.Add("columna3", "Nombre Jugador 2");
            dataGridView1.Columns.Add("columna4", "Puntaje Jugador 2");
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarProfe_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            {
                // Eliminar la fila seleccionada
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                ActualizarArchivoPuntajes();
            }
        }

        private void ActualizarArchivoPuntajes()
        {
            // Ruta del archivo de puntajes
            string archivoPuntajes = "Puntajes.txt";

            // Crear un StringBuilder para construir el contenido del archivo
            StringBuilder contenidoArchivo = new StringBuilder();

            // Recorrer las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Obtener los valores de las celdas de la fila
                string nombreJugador1 = fila.Cells["columna1"].Value?.ToString();
                string puntajeJugador1 = fila.Cells["columna2"].Value?.ToString();
                string nombreJugador2 = fila.Cells["columna3"].Value?.ToString();
                string puntajeJugador2 = fila.Cells["columna4"].Value?.ToString();

                // Comprobar que los valores no sean nulos
                if (!string.IsNullOrEmpty(nombreJugador1) && !string.IsNullOrEmpty(puntajeJugador1) &&
                    !string.IsNullOrEmpty(nombreJugador2) && !string.IsNullOrEmpty(puntajeJugador2))
                {
                    // Crear una línea con los valores y agregarla al contenido del archivo
                    string linea = $"{nombreJugador1},{puntajeJugador1},{nombreJugador2},{puntajeJugador2},{DateTime.Now}";
                    contenidoArchivo.AppendLine(linea);
                }
            }

            // Escribir el contenido actualizado en el archivo
            File.WriteAllText(archivoPuntajes, contenidoArchivo.ToString());
        }

    }
}
