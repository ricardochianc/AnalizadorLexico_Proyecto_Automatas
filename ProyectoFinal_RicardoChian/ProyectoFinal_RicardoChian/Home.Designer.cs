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
            this.gbx_ResultadoAnalisis = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Sets = new System.Windows.Forms.DataGridView();
            this.dgtv_Tokens = new System.Windows.Forms.DataGridView();
            this.lb_ExpresionRegular = new System.Windows.Forms.Label();
            this.btn_continuarAutomata = new System.Windows.Forms.PictureBox();
            this.gbx_Automata = new System.Windows.Forms.GroupBox();
            this.btn_GenerarArchivo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Follows = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgtv_Transiciones = new System.Windows.Forms.DataGridView();
            this.gbx_CargarArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continuar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CargarArchivo)).BeginInit();
            this.gbx_ResultadoAnalisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_Tokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continuarAutomata)).BeginInit();
            this.gbx_Automata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_GenerarArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Follows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_Transiciones)).BeginInit();
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
            this.lb_NombreArchivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // gbx_ResultadoAnalisis
            // 
            this.gbx_ResultadoAnalisis.BackColor = System.Drawing.Color.Transparent;
            this.gbx_ResultadoAnalisis.Controls.Add(this.btn_continuarAutomata);
            this.gbx_ResultadoAnalisis.Controls.Add(this.lb_ExpresionRegular);
            this.gbx_ResultadoAnalisis.Controls.Add(this.dgtv_Tokens);
            this.gbx_ResultadoAnalisis.Controls.Add(this.dgv_Sets);
            this.gbx_ResultadoAnalisis.Controls.Add(this.label4);
            this.gbx_ResultadoAnalisis.Controls.Add(this.label2);
            this.gbx_ResultadoAnalisis.Controls.Add(this.label3);
            this.gbx_ResultadoAnalisis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_ResultadoAnalisis.ForeColor = System.Drawing.Color.White;
            this.gbx_ResultadoAnalisis.Location = new System.Drawing.Point(12, 12);
            this.gbx_ResultadoAnalisis.Name = "gbx_ResultadoAnalisis";
            this.gbx_ResultadoAnalisis.Size = new System.Drawing.Size(670, 430);
            this.gbx_ResultadoAnalisis.TabIndex = 4;
            this.gbx_ResultadoAnalisis.TabStop = false;
            this.gbx_ResultadoAnalisis.Text = "2. Resultado de análisis de archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "SETS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOKENS:";
            // 
            // dgv_Sets
            // 
            this.dgv_Sets.AllowUserToAddRows = false;
            this.dgv_Sets.AllowUserToDeleteRows = false;
            this.dgv_Sets.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Sets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sets.ColumnHeadersVisible = false;
            this.dgv_Sets.Cursor = System.Windows.Forms.Cursors.No;
            this.dgv_Sets.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Sets.Location = new System.Drawing.Point(174, 80);
            this.dgv_Sets.Name = "dgv_Sets";
            this.dgv_Sets.ReadOnly = true;
            this.dgv_Sets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Sets.RowHeadersVisible = false;
            this.dgv_Sets.Size = new System.Drawing.Size(103, 209);
            this.dgv_Sets.TabIndex = 4;
            // 
            // dgtv_Tokens
            // 
            this.dgtv_Tokens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgtv_Tokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_Tokens.ColumnHeadersVisible = false;
            this.dgtv_Tokens.Cursor = System.Windows.Forms.Cursors.No;
            this.dgtv_Tokens.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgtv_Tokens.Location = new System.Drawing.Point(349, 80);
            this.dgtv_Tokens.Name = "dgtv_Tokens";
            this.dgtv_Tokens.ReadOnly = true;
            this.dgtv_Tokens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgtv_Tokens.RowHeadersVisible = false;
            this.dgtv_Tokens.Size = new System.Drawing.Size(96, 209);
            this.dgtv_Tokens.TabIndex = 5;
            // 
            // lb_ExpresionRegular
            // 
            this.lb_ExpresionRegular.AutoSize = true;
            this.lb_ExpresionRegular.Location = new System.Drawing.Point(66, 354);
            this.lb_ExpresionRegular.Name = "lb_ExpresionRegular";
            this.lb_ExpresionRegular.Size = new System.Drawing.Size(0, 17);
            this.lb_ExpresionRegular.TabIndex = 6;
            // 
            // btn_continuarAutomata
            // 
            this.btn_continuarAutomata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_continuarAutomata.Image = global::ProyectoFinal_RicardoChian.Properties.Resources.ContinuarVerde;
            this.btn_continuarAutomata.Location = new System.Drawing.Point(580, 372);
            this.btn_continuarAutomata.Name = "btn_continuarAutomata";
            this.btn_continuarAutomata.Size = new System.Drawing.Size(70, 37);
            this.btn_continuarAutomata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_continuarAutomata.TabIndex = 7;
            this.btn_continuarAutomata.TabStop = false;
            this.btn_continuarAutomata.Click += new System.EventHandler(this.btn_continuarAutomata_Click);
            // 
            // gbx_Automata
            // 
            this.gbx_Automata.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Automata.Controls.Add(this.dgtv_Transiciones);
            this.gbx_Automata.Controls.Add(this.label7);
            this.gbx_Automata.Controls.Add(this.dgv_Follows);
            this.gbx_Automata.Controls.Add(this.label6);
            this.gbx_Automata.Controls.Add(this.btn_GenerarArchivo);
            this.gbx_Automata.Controls.Add(this.label5);
            this.gbx_Automata.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Automata.ForeColor = System.Drawing.Color.White;
            this.gbx_Automata.Location = new System.Drawing.Point(12, 8);
            this.gbx_Automata.Name = "gbx_Automata";
            this.gbx_Automata.Size = new System.Drawing.Size(670, 430);
            this.gbx_Automata.TabIndex = 8;
            this.gbx_Automata.TabStop = false;
            this.gbx_Automata.Text = "3. Autómata";
            // 
            // btn_GenerarArchivo
            // 
            this.btn_GenerarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GenerarArchivo.Image = global::ProyectoFinal_RicardoChian.Properties.Resources.ContinuarVerde;
            this.btn_GenerarArchivo.Location = new System.Drawing.Point(587, 371);
            this.btn_GenerarArchivo.Name = "btn_GenerarArchivo";
            this.btn_GenerarArchivo.Size = new System.Drawing.Size(70, 37);
            this.btn_GenerarArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_GenerarArchivo.TabIndex = 7;
            this.btn_GenerarArchivo.TabStop = false;
            this.btn_GenerarArchivo.Click += new System.EventHandler(this.btn_GenerarArchivo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "EXPRESIÓN REGULAR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tabla de Follows:";
            // 
            // dgv_Follows
            // 
            this.dgv_Follows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Follows.Location = new System.Drawing.Point(19, 58);
            this.dgv_Follows.Name = "dgv_Follows";
            this.dgv_Follows.RowHeadersVisible = false;
            this.dgv_Follows.Size = new System.Drawing.Size(219, 150);
            this.dgv_Follows.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tabla de transiciones:";
            // 
            // dgtv_Transiciones
            // 
            this.dgtv_Transiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_Transiciones.Location = new System.Drawing.Point(19, 248);
            this.dgtv_Transiciones.Name = "dgtv_Transiciones";
            this.dgtv_Transiciones.Size = new System.Drawing.Size(556, 150);
            this.dgtv_Transiciones.TabIndex = 11;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_RicardoChian.Properties.Resources.FondoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 456);
            this.Controls.Add(this.gbx_CargarArchivo);
            this.Controls.Add(this.gbx_ResultadoAnalisis);
            this.Controls.Add(this.gbx_Automata);
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
            this.gbx_ResultadoAnalisis.ResumeLayout(false);
            this.gbx_ResultadoAnalisis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_Tokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continuarAutomata)).EndInit();
            this.gbx_Automata.ResumeLayout(false);
            this.gbx_Automata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_GenerarArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Follows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_Transiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_CargarArchivo;
        private System.Windows.Forms.PictureBox btn_CargarArchivo;
        private System.Windows.Forms.Label lb_NombreArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_archivo;
        private System.Windows.Forms.PictureBox btn_continuar;
        private System.Windows.Forms.GroupBox gbx_ResultadoAnalisis;
        private System.Windows.Forms.Label lb_ExpresionRegular;
        private System.Windows.Forms.DataGridView dgtv_Tokens;
        private System.Windows.Forms.DataGridView dgv_Sets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_continuarAutomata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbx_Automata;
        private System.Windows.Forms.DataGridView dgtv_Transiciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Follows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btn_GenerarArchivo;
        private System.Windows.Forms.Label label5;
    }
}

