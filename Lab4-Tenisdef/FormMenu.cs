using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Tenisdef
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego();
            
            this.Hide(); 
            juego.ShowDialog(); 
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPuntajes_Click(object sender, EventArgs e)
        {
            Puntajes puntajesForm = new Puntajes();

            // Mostrar el formulario de puntajes
            puntajesForm.Show();
        }
    }
}
