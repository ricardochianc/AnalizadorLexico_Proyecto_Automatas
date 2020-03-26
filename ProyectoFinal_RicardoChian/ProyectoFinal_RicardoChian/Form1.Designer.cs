namespace ProyectoFinal_RicardoChian
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_NombreArchivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CargarArchivo = new System.Windows.Forms.PictureBox();
            this.lb_Correcto = new System.Windows.Forms.Label();
            this.lb_Error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CargarArchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb_Error);
            this.groupBox1.Controls.Add(this.lb_Correcto);
            this.groupBox1.Controls.Add(this.lb_NombreArchivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_CargarArchivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Cargar archivo";
            // 
            // lb_NombreArchivo
            // 
            this.lb_NombreArchivo.BackColor = System.Drawing.Color.White;
            this.lb_NombreArchivo.ForeColor = System.Drawing.Color.Black;
            this.lb_NombreArchivo.Location = new System.Drawing.Point(167, 187);
            this.lb_NombreArchivo.Name = "lb_NombreArchivo";
            this.lb_NombreArchivo.Size = new System.Drawing.Size(325, 23);
            this.lb_NombreArchivo.TabIndex = 2;
            this.lb_NombreArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo:";
            // 
            // btn_CargarArchivo
            // 
            this.btn_CargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CargarArchivo.Image = global::ProyectoFinal_RicardoChian.Properties.Resources.Cargar_archivo;
            this.btn_CargarArchivo.Location = new System.Drawing.Point(499, 170);
            this.btn_CargarArchivo.Name = "btn_CargarArchivo";
            this.btn_CargarArchivo.Size = new System.Drawing.Size(50, 50);
            this.btn_CargarArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CargarArchivo.TabIndex = 0;
            this.btn_CargarArchivo.TabStop = false;
            // 
            // lb_Correcto
            // 
            this.lb_Correcto.AutoSize = true;
            this.lb_Correcto.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Correcto.ForeColor = System.Drawing.Color.LawnGreen;
            this.lb_Correcto.Location = new System.Drawing.Point(9, 399);
            this.lb_Correcto.Name = "lb_Correcto";
            this.lb_Correcto.Size = new System.Drawing.Size(323, 19);
            this.lb_Correcto.TabIndex = 3;
            this.lb_Correcto.Text = "El archivo se ha procesado correctamente";
            this.lb_Correcto.Visible = false;
            // 
            // lb_Error
            // 
            this.lb_Error.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Error.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_Error.Location = new System.Drawing.Point(9, 332);
            this.lb_Error.Name = "lb_Error";
            this.lb_Error.Size = new System.Drawing.Size(483, 86);
            this.lb_Error.TabIndex = 4;
            this.lb_Error.Text = "El archivo se ha procesado correctamente";
            this.lb_Error.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lb_Error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_RicardoChian.Properties.Resources.FondoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 456);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escaner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CargarArchivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btn_CargarArchivo;
        private System.Windows.Forms.Label lb_NombreArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Error;
        private System.Windows.Forms.Label lb_Correcto;
    }
}

