namespace Lab4_Tenisdef
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPuntajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Location = new System.Drawing.Point(146, 113);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(186, 83);
            this.btnIniciarJuego.TabIndex = 0;
            this.btnIniciarJuego.Text = "Iniciar";
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(430, 113);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(186, 83);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPuntajes
            // 
            this.btnPuntajes.Location = new System.Drawing.Point(284, 258);
            this.btnPuntajes.Name = "btnPuntajes";
            this.btnPuntajes.Size = new System.Drawing.Size(186, 83);
            this.btnPuntajes.TabIndex = 2;
            this.btnPuntajes.Text = "Puntajes";
            this.btnPuntajes.UseVisualStyleBackColor = true;
            this.btnPuntajes.Click += new System.EventHandler(this.btnPuntajes_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPuntajes);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIniciarJuego);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarJuego;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPuntajes;
    }
}