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
    public partial class FormJuego : Form
    {

        public string NombreJugador1 { get; set; }
        public string NombreJugador2 { get; set; }

        public FormJuego()
        {
            InitializeComponent();
            this.Load += (sender, e) =>
            {
                label1.Text = NombreJugador1;
                label2.Text = NombreJugador2;
            };


            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
        }

        

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            
            int movement = e.Delta > 0 ? -10 : 10; 
            MoveButton(btn2, movement);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    MoveButton(btn1, -10); // Mueve hacia arriba
                    break;
                case Keys.S:
                    MoveButton(btn1, 10); // Mueve hacia abajo
                    break;
            }
        }

        private void MoveButton(Button btn, int deltaY)
        {
            // Asegúrate de que el botón no salga de los límites del formulario
            int newY = btn.Location.Y + deltaY;
            if (newY >= 0 && newY <= this.ClientSize.Height - btn.Height)
            {
                btn.Location = new Point(btn.Location.X, newY);
            }
        }

        private void trmMove_Tick(object sender, EventArgs e)
        {
            Colision();
            
        }

        int arriba;
        int derecha;
        int abajo;
        int izquierda;
        int velx = 3;
        int vely = 3;

        int jug1 = 0;   
        int jug2 = 0;
        private void Colision()
        {
            int raquetaIzqArriba = btn1.Top;
            int raquetaIzqDerecha = btn1.Left + btn1.Width;
            int raquetaIzqAbajo = btn1.Top + btn1.Height;
            int raquetaIzqizq = btn1.Left;

            int raquetaDerArriba = btn2.Top;
            int raquetaDerDerecha = btn2.Left + btn1.Width;
            int raquetaDerAbajo = btn2.Top + btn1.Height;
            int raquetaDerizq = btn2.Left;

            int ballArriba = ball.Top;
            int ballDerecha = ball.Left + ball.Width;
            int ballAbajo = ball.Top + ball.Height;
            int ballIzquierda = ball.Left;

            // Actualizar posición de la pelota
            ball.Top += vely;
            ball.Left += velx;

            // Definir límites del formulario
            arriba = 0;
            derecha = this.ClientSize.Width - ball.Width;
            abajo = this.ClientSize.Height - ball.Height;
            izquierda = 0;

            
            // Colisión con la raqueta izquierda
            if (ballAbajo >= raquetaIzqArriba && ballArriba <= raquetaIzqAbajo &&
                ballIzquierda <= raquetaIzqDerecha && ballDerecha >= raquetaIzqizq)
            {
                velx = 3; 
            }

            // Colisión con la raqueta derecha
            if (ballAbajo >= raquetaDerArriba && ballArriba <= raquetaDerAbajo &&
                ballIzquierda <= raquetaDerDerecha && ballDerecha >= raquetaDerizq)
            {
                velx = -3; // Invertir la dirección horizontal
            }


            // Comprobar colisión con el borde superior
            if (ball.Top <= arriba)
            {
                vely *= -1; // Invertir la dirección vertical
            }

            // Comprobar colisión con el borde inferior
            if (ball.Top >= abajo)
            {
                vely *= -1; // Invertir la dirección vertical
            }

           
            // Comprobar colisión con el borde izquierdo y actualizar puntajes
            if (ball.Left <= izquierda)
            {
                jug2++;
                lblJugador2.Text = jug2.ToString(); // Actualizar el puntaje en el label
                if (jug2 >= 10)
                {
                    PausarJuego();
                    
                    
                    MessageBox.Show("Jugador 2 ha ganado el juego!");
                    MostrarFormularioPuntajes(); // Mostrar formulario de puntajes
                }
                else
                {
                    Reset(); // Reposicionar la pelota para el siguiente punto
                }
            }

            // Comprobar colisión con el borde derecho y actualizar puntajes
            if (ball.Left >= derecha)
            {
                jug1++;
                lblJugador1.Text = jug1.ToString(); // Actualizar el puntaje en el label
                if (jug1 >= 10)
                {
                    PausarJuego();
                    
                    
                    MessageBox.Show("Jugador 1 ha ganado el juego!");
                    MostrarFormularioPuntajes(); // Mostrar formulario de puntajes
                }
                else
                {
                    Reset(); // Reposicionar la pelota para el siguiente punto
                }
            }
        }

        private void PausarJuego()
        {
            trmMove.Enabled = false; // Detiene el temporizador o cualquier otra lógica que haga que el juego continúe
            
        }

        private void MostrarFormularioPuntajes()
        {
            Puntajes formularioPuntajes = new Puntajes();

            // Suscribir al evento FormClosed del formulario de puntajes
            formularioPuntajes.FormClosed += FormularioPuntajes_FormClosed;

            formularioPuntajes.ShowDialog(); // Mostrar el formulario como un diálogo
        }





        private void Reset()
        {
            // Centrar la pelota en el área de juego
            ball.Top = this.ClientSize.Height / 2 - ball.Height / 2;
            ball.Left = this.ClientSize.Width / 2 - ball.Width / 2;

            // Actualizar los puntajes en los labels
            lblJugador1.Text = jug1.ToString();
            lblJugador2.Text = jug2.ToString();
        }

        private void ReiniciarJuego()
        {
            jug1 = 0;
            jug2 = 0;
            lblJugador1.Text = "0";
            lblJugador2.Text = "0";
            Reset();
            trmMove.Enabled = true; // Reactivar el juego
         
        }

      

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void FormularioPuntajes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Cerrar el formulario de juego cuando se cierra el formulario de puntajes
        }
    }
}
