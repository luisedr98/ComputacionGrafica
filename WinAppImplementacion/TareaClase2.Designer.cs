namespace WinAppImplementacion
{
    partial class TareaClase2
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
            this.PbxLienzo = new System.Windows.Forms.PictureBox();
            this.BtnGraficar = new System.Windows.Forms.Button();
            this.BtnEjes = new System.Windows.Forms.Button();
            this.Interpolar = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.Btninterrpolar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxLienzo
            // 
            this.PbxLienzo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PbxLienzo.Location = new System.Drawing.Point(0, 0);
            this.PbxLienzo.Name = "PbxLienzo";
            this.PbxLienzo.Size = new System.Drawing.Size(700, 420);
            this.PbxLienzo.TabIndex = 0;
            this.PbxLienzo.TabStop = false;
            this.PbxLienzo.Click += new System.EventHandler(this.PbxLienzo_Click);
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.Location = new System.Drawing.Point(22, 444);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(75, 23);
            this.BtnGraficar.TabIndex = 1;
            this.BtnGraficar.Text = "Graficar";
            this.BtnGraficar.UseVisualStyleBackColor = true;
            this.BtnGraficar.Visible = false;
            this.BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // BtnEjes
            // 
            this.BtnEjes.Location = new System.Drawing.Point(537, 444);
            this.BtnEjes.Name = "BtnEjes";
            this.BtnEjes.Size = new System.Drawing.Size(75, 23);
            this.BtnEjes.TabIndex = 2;
            this.BtnEjes.Text = "Ejes";
            this.BtnEjes.UseVisualStyleBackColor = true;
            this.BtnEjes.Visible = false;
            this.BtnEjes.Click += new System.EventHandler(this.BtnEjes_Click);
            // 
            // Interpolar
            // 
            this.Interpolar.Location = new System.Drawing.Point(103, 444);
            this.Interpolar.Name = "Interpolar";
            this.Interpolar.Size = new System.Drawing.Size(75, 23);
            this.Interpolar.TabIndex = 3;
            this.Interpolar.Text = "Interporal";
            this.Interpolar.UseVisualStyleBackColor = true;
            this.Interpolar.Visible = false;
            this.Interpolar.Click += new System.EventHandler(this.Interpolar_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Location = new System.Drawing.Point(618, 437);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(75, 23);
            this.BtnApagar.TabIndex = 4;
            this.BtnApagar.Text = "Superficie";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btninterrpolar2
            // 
            this.Btninterrpolar2.Location = new System.Drawing.Point(214, 445);
            this.Btninterrpolar2.Name = "Btninterrpolar2";
            this.Btninterrpolar2.Size = new System.Drawing.Size(75, 23);
            this.Btninterrpolar2.TabIndex = 5;
            this.Btninterrpolar2.Text = "Interpolar 2";
            this.Btninterrpolar2.UseVisualStyleBackColor = true;
            this.Btninterrpolar2.Visible = false;
            this.Btninterrpolar2.Click += new System.EventHandler(this.Btninterrpolar2_Click);
            // 
            // TareaClase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 472);
            this.Controls.Add(this.Btninterrpolar2);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.Interpolar);
            this.Controls.Add(this.BtnEjes);
            this.Controls.Add(this.BtnGraficar);
            this.Controls.Add(this.PbxLienzo);
            this.Name = "TareaClase2";
            this.Text = "Superficies";
            this.Load += new System.EventHandler(this.TareaClase2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLienzo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PbxLienzo;
        private Button BtnGraficar;
        private Button BtnEjes;
        private Button Interpolar;
        private Button BtnApagar;
        private Button Btninterrpolar2;
    }
}