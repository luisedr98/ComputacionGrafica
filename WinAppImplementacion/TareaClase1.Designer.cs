namespace WinAppImplementacion
{
    partial class TareaClase1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PbxPantalla = new System.Windows.Forms.PictureBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnApagarSegmento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnApagarLazo = new System.Windows.Forms.Button();
            this.BtnOffLazo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxPantalla
            // 
            this.PbxPantalla.BackColor = System.Drawing.SystemColors.Control;
            this.PbxPantalla.Location = new System.Drawing.Point(0, 0);
            this.PbxPantalla.Name = "PbxPantalla";
            this.PbxPantalla.Size = new System.Drawing.Size(700, 420);
            this.PbxPantalla.TabIndex = 0;
            this.PbxPantalla.TabStop = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(26, 436);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(116, 23);
            this.BtnDraw.TabIndex = 3;
            this.BtnDraw.Text = "Gráficos";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnApagarSegmento
            // 
            this.BtnApagarSegmento.Location = new System.Drawing.Point(148, 436);
            this.BtnApagarSegmento.Name = "BtnApagarSegmento";
            this.BtnApagarSegmento.Size = new System.Drawing.Size(75, 23);
            this.BtnApagarSegmento.TabIndex = 4;
            this.BtnApagarSegmento.Text = "Apagar S";
            this.BtnApagarSegmento.UseVisualStyleBackColor = true;
            this.BtnApagarSegmento.Click += new System.EventHandler(this.BtnApagarCirculo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "A. Circulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnApagarLazo
            // 
            this.BtnApagarLazo.Location = new System.Drawing.Point(322, 436);
            this.BtnApagarLazo.Name = "BtnApagarLazo";
            this.BtnApagarLazo.Size = new System.Drawing.Size(75, 23);
            this.BtnApagarLazo.TabIndex = 6;
            this.BtnApagarLazo.Text = "A. Raiz";
            this.BtnApagarLazo.UseVisualStyleBackColor = true;
            this.BtnApagarLazo.Click += new System.EventHandler(this.BtnApagarLazo_Click);
            // 
            // BtnOffLazo
            // 
            this.BtnOffLazo.Location = new System.Drawing.Point(416, 436);
            this.BtnOffLazo.Name = "BtnOffLazo";
            this.BtnOffLazo.Size = new System.Drawing.Size(75, 23);
            this.BtnOffLazo.TabIndex = 7;
            this.BtnOffLazo.Text = "A. Lazo";
            this.BtnOffLazo.UseVisualStyleBackColor = true;
            this.BtnOffLazo.Click += new System.EventHandler(this.BtnOffLazo_Click);
            // 
            // TareaClase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(708, 481);
            this.Controls.Add(this.BtnOffLazo);
            this.Controls.Add(this.BtnApagarLazo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnApagarSegmento);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.PbxPantalla);
            this.Name = "TareaClase1";
            this.Text = "Computación Científica";
            this.Load += new System.EventHandler(this.FormPixel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPantalla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PbxPantalla;
        private Button BtnDraw;
        private Button BtnApagarSegmento;
        private Button button1;
        private Button BtnApagarLazo;
        private Button BtnOffLazo;
    }
}