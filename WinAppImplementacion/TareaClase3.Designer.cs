namespace WinAppImplementacion
{
    partial class TareaClase3
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
            this.BtnGraficar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.PbxPantalla = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.Location = new System.Drawing.Point(522, 458);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(75, 23);
            this.BtnGraficar.TabIndex = 0;
            this.BtnGraficar.Text = "Graficar";
            this.BtnGraficar.UseVisualStyleBackColor = true;
            this.BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(628, 458);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 1;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // PbxPantalla
            // 
            this.PbxPantalla.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PbxPantalla.Location = new System.Drawing.Point(0, 0);
            this.PbxPantalla.Name = "PbxPantalla";
            this.PbxPantalla.Size = new System.Drawing.Size(700, 420);
            this.PbxPantalla.TabIndex = 2;
            this.PbxPantalla.TabStop = false;
            // 
            // GestionImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 493);
            this.Controls.Add(this.PbxPantalla);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnGraficar);
            this.Name = "GestionImagenes";
            this.Text = "Gestion Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.PbxPantalla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnGraficar;
        private Button BtnBorrar;
        private PictureBox PbxPantalla;
    }
}