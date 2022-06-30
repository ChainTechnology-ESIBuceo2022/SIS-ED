namespace Presentacion.BackOffice
{
    partial class AñadirImagen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBanner = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.lblResultadoSubir = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pteImagen = new System.Windows.Forms.PictureBox();
            this.txtDirectorioOrigen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pteImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 599);
            this.panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(0, 56);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(200, 37);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(200, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 49);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir Banner de publicidad";
            // 
            // btnAddBanner
            // 
            this.btnAddBanner.Location = new System.Drawing.Point(431, 36);
            this.btnAddBanner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBanner.Name = "btnAddBanner";
            this.btnAddBanner.Size = new System.Drawing.Size(142, 31);
            this.btnAddBanner.TabIndex = 4;
            this.btnAddBanner.Text = "Subir al sistema";
            this.btnAddBanner.UseVisualStyleBackColor = true;
            this.btnAddBanner.Click += new System.EventHandler(this.btnAddBanner_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(160, 76);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(238, 27);
            this.txtEmpresa.TabIndex = 7;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Location = new System.Drawing.Point(254, 130);
            this.btnBuscarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(143, 31);
            this.btnBuscarImagen.TabIndex = 9;
            this.btnBuscarImagen.Text = "Buscar imagen";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.lblResultadoSubir);
            this.gbx.Controls.Add(this.txtNombreArchivo);
            this.gbx.Controls.Add(this.label3);
            this.gbx.Controls.Add(this.btnAddBanner);
            this.gbx.Controls.Add(this.label4);
            this.gbx.Controls.Add(this.txtEmpresa);
            this.gbx.Location = new System.Drawing.Point(274, 330);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(597, 125);
            this.gbx.TabIndex = 10;
            this.gbx.TabStop = false;
            this.gbx.Text = "Información imagen";
            // 
            // lblResultadoSubir
            // 
            this.lblResultadoSubir.AutoSize = true;
            this.lblResultadoSubir.Location = new System.Drawing.Point(493, 83);
            this.lblResultadoSubir.Name = "lblResultadoSubir";
            this.lblResultadoSubir.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoSubir.TabIndex = 12;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(160, 40);
            this.txtNombreArchivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(238, 27);
            this.txtNombreArchivo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del archivo:";
            // 
            // pteImagen
            // 
            this.pteImagen.Location = new System.Drawing.Point(446, 67);
            this.pteImagen.Name = "pteImagen";
            this.pteImagen.Size = new System.Drawing.Size(307, 160);
            this.pteImagen.TabIndex = 11;
            this.pteImagen.TabStop = false;
            // 
            // txtDirectorioOrigen
            // 
            this.txtDirectorioOrigen.AutoSize = true;
            this.txtDirectorioOrigen.Location = new System.Drawing.Point(254, 260);
            this.txtDirectorioOrigen.Name = "txtDirectorioOrigen";
            this.txtDirectorioOrigen.Size = new System.Drawing.Size(0, 20);
            this.txtDirectorioOrigen.TabIndex = 12;
            // 
            // AñadirImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.txtDirectorioOrigen);
            this.Controls.Add(this.pteImagen);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AñadirImagen";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pteImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnVolver;
        private Panel panel3;
        private Label label1;
        private Button btnAddBanner;
        private Label label4;
        private TextBox txtEmpresa;
        private Button btnBuscarImagen;
        private GroupBox gbx;
        private Label lblResultadoSubir;
        private TextBox txtNombreArchivo;
        private Label label3;
        private PictureBox pteImagen;
        private Label txtDirectorioOrigen;
    }
}