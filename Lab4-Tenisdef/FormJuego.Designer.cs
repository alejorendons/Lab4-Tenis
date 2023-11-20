namespace Lab4_Tenisdef
{
    partial class FormJuego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJuego));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.PictureBox();
            this.trmMove = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(3, 189);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(16, 128);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(881, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(16, 128);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(410, 208);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(68, 75);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // trmMove
            // 
            this.trmMove.Enabled = true;
            this.trmMove.Interval = 10;
            this.trmMove.Tick += new System.EventHandler(this.trmMove_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Juagdor 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(639, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Juagdor 2:";
            // 
            // lblJugador1
            // 
            this.lblJugador1.AutoSize = true;
            this.lblJugador1.ForeColor = System.Drawing.Color.Red;
            this.lblJugador1.Location = new System.Drawing.Point(258, 9);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(14, 16);
            this.lblJugador1.TabIndex = 5;
            this.lblJugador1.Text = "0";
            // 
            // lblJugador2
            // 
            this.lblJugador2.AutoSize = true;
            this.lblJugador2.ForeColor = System.Drawing.Color.Red;
            this.lblJugador2.Location = new System.Drawing.Point(712, 9);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(14, 16);
            this.lblJugador2.TabIndex = 6;
            this.lblJugador2.Text = "0";
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Lab4_Tenisdef.Properties.Resources._34234903_suelo_parcela_campo_sport_court_tennis_con_blanco_net_ilustración_vectorial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 491);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "FormJuego";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer trmMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblJugador2;
    }
}

