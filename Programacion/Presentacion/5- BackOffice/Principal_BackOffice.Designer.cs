namespace Presentacion
{
    partial class Principal_BackOffice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataUsuarios = new System.Windows.Forms.DataGridView();
            this.lblGestionUsuarios = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAddbanner = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataUsuarios
            // 
            this.dataUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dataUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.GridColor = System.Drawing.Color.White;
            this.dataUsuarios.Location = new System.Drawing.Point(156, 60);
            this.dataUsuarios.Name = "dataUsuarios";
            this.dataUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUsuarios.RowTemplate.Height = 25;
            this.dataUsuarios.Size = new System.Drawing.Size(774, 261);
            this.dataUsuarios.TabIndex = 0;
            this.dataUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsuarios_CellClick);
            // 
            // lblGestionUsuarios
            // 
            this.lblGestionUsuarios.AutoSize = true;
            this.lblGestionUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblGestionUsuarios.Location = new System.Drawing.Point(324, 22);
            this.lblGestionUsuarios.Name = "lblGestionUsuarios";
            this.lblGestionUsuarios.Size = new System.Drawing.Size(160, 21);
            this.lblGestionUsuarios.TabIndex = 1;
            this.lblGestionUsuarios.Text = "Gestion de usuarios";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdministrador.ForeColor = System.Drawing.Color.Black;
            this.lblAdministrador.Location = new System.Drawing.Point(15, 19);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(137, 21);
            this.lblAdministrador.TabIndex = 2;
            this.lblAdministrador.Text = "Panel de control";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnAddbanner);
            this.panel1.Controls.Add(this.lblAdministrador);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 447);
            this.panel1.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(0, 335);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(161, 41);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAddbanner
            // 
            this.btnAddbanner.BackColor = System.Drawing.Color.White;
            this.btnAddbanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddbanner.ForeColor = System.Drawing.Color.Black;
            this.btnAddbanner.Location = new System.Drawing.Point(0, 218);
            this.btnAddbanner.Name = "btnAddbanner";
            this.btnAddbanner.Size = new System.Drawing.Size(161, 41);
            this.btnAddbanner.TabIndex = 8;
            this.btnAddbanner.Text = "Añadir Banners";
            this.btnAddbanner.UseVisualStyleBackColor = false;
            this.btnAddbanner.Click += new System.EventHandler(this.btnAddbanner_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(0, 111);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(161, 41);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(0, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 41);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(648, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(262, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Usuario con ID: ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblGestionUsuarios);
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 60);
            this.panel2.TabIndex = 4;
            // 
            // Principal_BackOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 378);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataUsuarios);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Principal_BackOffice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_BackOffice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataUsuarios;
        private Label lblGestionUsuarios;
        private Label lblAdministrador;
        private Panel panel1;
        private Panel panel2;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAddbanner;
        private Button btnVolver;
    }
}