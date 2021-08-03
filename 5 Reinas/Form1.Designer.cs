namespace _5_Reinas
{
    partial class Reinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reinas));
            this.Tablero = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.R1 = new System.Windows.Forms.PictureBox();
            this.R2 = new System.Windows.Forms.PictureBox();
            this.R3 = new System.Windows.Forms.PictureBox();
            this.R4 = new System.Windows.Forms.PictureBox();
            this.R5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R5)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablero
            // 
            this.Tablero.BackColor = System.Drawing.Color.Transparent;
            this.Tablero.Image = ((System.Drawing.Image)(resources.GetObject("Tablero.Image")));
            this.Tablero.Location = new System.Drawing.Point(13, 13);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(425, 425);
            this.Tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tablero.TabIndex = 0;
            this.Tablero.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(469, 13);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(469, 42);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Visible = false;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(469, 71);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Visible = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(469, 100);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Visible = false;
            // 
            // R1
            // 
            this.R1.BackColor = System.Drawing.Color.Transparent;
            this.R1.Image = global::_5_Reinas.Properties.Resources.Reina;
            this.R1.Location = new System.Drawing.Point(78, 80);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(56, 56);
            this.R1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.R1.TabIndex = 5;
            this.R1.TabStop = false;
            // 
            // R2
            // 
            this.R2.Image = global::_5_Reinas.Properties.Resources.Reina;
            this.R2.Location = new System.Drawing.Point(78, 140);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(56, 56);
            this.R2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.R2.TabIndex = 6;
            this.R2.TabStop = false;
            // 
            // R3
            // 
            this.R3.Image = global::_5_Reinas.Properties.Resources.Reina;
            this.R3.Location = new System.Drawing.Point(78, 199);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(56, 56);
            this.R3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.R3.TabIndex = 7;
            this.R3.TabStop = false;
            // 
            // R4
            // 
            this.R4.Image = global::_5_Reinas.Properties.Resources.Reina;
            this.R4.Location = new System.Drawing.Point(78, 258);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(56, 56);
            this.R4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.R4.TabIndex = 8;
            this.R4.TabStop = false;
            // 
            // R5
            // 
            this.R5.Image = global::_5_Reinas.Properties.Resources.Reina;
            this.R5.Location = new System.Drawing.Point(78, 317);
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(56, 56);
            this.R5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.R5.TabIndex = 9;
            this.R5.TabStop = false;
            // 
            // Reinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.R5);
            this.Controls.Add(this.R4);
            this.Controls.Add(this.R3);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.Tablero);
            this.Name = "Reinas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Reinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tablero;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox R1;
        private System.Windows.Forms.PictureBox R2;
        private System.Windows.Forms.PictureBox R3;
        private System.Windows.Forms.PictureBox R4;
        private System.Windows.Forms.PictureBox R5;
    }
}

