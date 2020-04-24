namespace ProyectoFinal_RicardoChian
{
    partial class Home
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
            this.gbx_CargarArchivo = new System.Windows.Forms.GroupBox();
            this.btn_continuar = new System.Windows.Forms.PictureBox();
            this.lb_NombreArchivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CargarArchivo = new System.Windows.Forms.PictureBox();
            this.openFileDialog_archivo = new System.Windows.Forms.OpenFileDialog();
            this.gbx_CargarArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continuar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CargarArchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_CargarArchivo
            // 
            this.gbx_CargarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.gbx_CargarArchivo.Controls.Add(this.btn_continuar);
            this.gbx_CargarArchivo.Controls.Add(this.lb_NombreArchivo);
            this.gbx_CargarArchivo.Controls.Add(this.label1);
            this.gbx_CargarArchivo.Controls.Add(this.btn_CargarArchivo);
            this.gbx_CargarArchivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_CargarArchivo.ForeColor = System.Drawing.Color.White;
            this.gbx_CargarArchivo.Location = new System.Drawing.Point(12, 12);
            this.gbx_CargarArchivo.Name = "gbx_CargarArchivo";
            this.gbx_CargarArchivo.Size = new System.Drawing.Size(670, 430);
            this.gbx_CargarArchivo.TabIndex = 0;
            this.gbx_CargarArchivo.TabStop = false;
            this.gbx_CargarArchivo.Text = "1. Cargar archivo";
            // 
            // btn_continuar
            // 
            this.btn_continuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_continuar.Image = global::ProyectoFinal_RicardoChian.Properties.Resources.ContinuarVerde;
            this.btn_continuar.Location = new System.Drawing.Point(307, 238);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(70, 37);
            this.btn_continuar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_continuar.TabIndex = 3;
            this.btn_continuar.TabStop = false;
            this.btn_continuar.Visible = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
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
            this.btn_CargarArchivo.Click += new System.EventHandler(this.btn_CargarArchivo_Click);
            // 
            // openFileDialog_archivo
            // 
            this.openFileDialog_archivo.DefaultExt = "txt";
            this.openFileDialog_archivo.Filter = "Archivos de texto|*.txt";
            this.openFileDialog_archivo.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_archivo_FileOk);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_RicardoChian.Properties.Resources.FondoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 456);
            this.Controls.Add(this.gbx_CargarArchivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizador léxico";
            this.gbx_CargarArchivo.ResumeLayout(false);
            this.gbx_CargarArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continuar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CargarArchivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_CargarArchivo;
        private System.Windows.Forms.PictureBox btn_CargarArchivo;
        private System.Windows.Forms.Label lb_NombreArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_archivo;
        private System.Windows.Forms.PictureBox btn_continuar;
    }
}

