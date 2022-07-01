namespace Proyecto
{
    partial class Principal
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
            this.btnAppEstandar = new System.Windows.Forms.Button();
            this.btnAppBackoffice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAppEstandar
            // 
            this.btnAppEstandar.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAppEstandar.Location = new System.Drawing.Point(112, 124);
            this.btnAppEstandar.Name = "btnAppEstandar";
            this.btnAppEstandar.Size = new System.Drawing.Size(355, 41);
            this.btnAppEstandar.TabIndex = 0;
            this.btnAppEstandar.Text = "Aplicacion Usuario Estandar";
            this.btnAppEstandar.UseVisualStyleBackColor = true;
            this.btnAppEstandar.Click += new System.EventHandler(this.btnAppEstandar_Click);
            // 
            // btnAppBackoffice
            // 
            this.btnAppBackoffice.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAppBackoffice.Location = new System.Drawing.Point(112, 200);
            this.btnAppBackoffice.Name = "btnAppBackoffice";
            this.btnAppBackoffice.Size = new System.Drawing.Size(355, 41);
            this.btnAppBackoffice.TabIndex = 1;
            this.btnAppBackoffice.Text = "Aplicacion BackOffice";
            this.btnAppBackoffice.UseVisualStyleBackColor = true;
            this.btnAppBackoffice.Click += new System.EventHandler(this.btnBackoffice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esta interfaz es solo para desarrollar pruebas y evaluar el codigo";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAppBackoffice);
            this.Controls.Add(this.btnAppEstandar);
            this.Name = "Principal";
            this.Text = "Mantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAppEstandar;
        private Button btnAppBackoffice;
        private Label label1;
    }
}