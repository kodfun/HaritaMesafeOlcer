namespace HaritaMesafeOlcer
{
    partial class Form1
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
            this.pboHarita = new System.Windows.Forms.PictureBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnSifirla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboHarita)).BeginInit();
            this.SuspendLayout();
            // 
            // pboHarita
            // 
            this.pboHarita.Image = global::HaritaMesafeOlcer.Properties.Resources.harita;
            this.pboHarita.Location = new System.Drawing.Point(12, 12);
            this.pboHarita.Name = "pboHarita";
            this.pboHarita.Size = new System.Drawing.Size(998, 515);
            this.pboHarita.TabIndex = 0;
            this.pboHarita.TabStop = false;
            this.pboHarita.Paint += new System.Windows.Forms.PaintEventHandler(this.pboHarita_Paint);
            this.pboHarita.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pboHarita_MouseClick);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSonuc.Location = new System.Drawing.Point(12, 553);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(998, 39);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "Haritada arasındaki mesafeyi öğrenmek istediğiniz iki noktaya sırayla tıklayınız." +
    "";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(933, 533);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 23);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "SIFIRLA";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 631);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.pboHarita);
            this.Name = "Form1";
            this.Text = "Harita Mesafe Ölçer";
            ((System.ComponentModel.ISupportInitialize)(this.pboHarita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pboHarita;
        private Label lblSonuc;
        private Button btnSifirla;
    }
}