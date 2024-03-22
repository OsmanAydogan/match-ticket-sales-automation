namespace MacBiletiOtomasyon
{
    partial class MacEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacEkle));
            this.rkp1 = new System.Windows.Forms.Label();
            this.txtrakip1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.btnamblem1 = new System.Windows.Forms.Button();
            this.btnmacekle = new System.Windows.Forms.Button();
            this.amblemeklepcbx = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.amblemeklepcbx)).BeginInit();
            this.SuspendLayout();
            // 
            // rkp1
            // 
            this.rkp1.AutoSize = true;
            this.rkp1.BackColor = System.Drawing.Color.Transparent;
            this.rkp1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.rkp1.ForeColor = System.Drawing.Color.White;
            this.rkp1.Location = new System.Drawing.Point(91, 268);
            this.rkp1.Name = "rkp1";
            this.rkp1.Size = new System.Drawing.Size(109, 23);
            this.rkp1.TabIndex = 0;
            this.rkp1.Text = "Rakip  Adı:";
            // 
            // txtrakip1
            // 
            this.txtrakip1.Location = new System.Drawing.Point(231, 269);
            this.txtrakip1.Multiline = true;
            this.txtrakip1.Name = "txtrakip1";
            this.txtrakip1.Size = new System.Drawing.Size(100, 22);
            this.txtrakip1.TabIndex = 1;
            this.txtrakip1.TextChanged += new System.EventHandler(this.txtrakip1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(431, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih:";
            // 
            // dtpicker
            // 
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker.Location = new System.Drawing.Point(538, 268);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(101, 22);
            this.dtpicker.TabIndex = 5;
            // 
            // btnamblem1
            // 
            this.btnamblem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnamblem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnamblem1.BackgroundImage")));
            this.btnamblem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnamblem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnamblem1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnamblem1.Location = new System.Drawing.Point(146, 318);
            this.btnamblem1.Name = "btnamblem1";
            this.btnamblem1.Size = new System.Drawing.Size(198, 90);
            this.btnamblem1.TabIndex = 6;
            this.btnamblem1.Text = "Amblem Ekle";
            this.btnamblem1.UseVisualStyleBackColor = false;
            this.btnamblem1.Click += new System.EventHandler(this.btnamblem1_Click);
            // 
            // btnmacekle
            // 
            this.btnmacekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmacekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmacekle.BackgroundImage")));
            this.btnmacekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmacekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmacekle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmacekle.Location = new System.Drawing.Point(470, 318);
            this.btnmacekle.Name = "btnmacekle";
            this.btnmacekle.Size = new System.Drawing.Size(198, 90);
            this.btnmacekle.TabIndex = 7;
            this.btnmacekle.Text = "Maç Ekle";
            this.btnmacekle.UseVisualStyleBackColor = false;
            this.btnmacekle.Click += new System.EventHandler(this.btnmacekle_Click);
            // 
            // amblemeklepcbx
            // 
            this.amblemeklepcbx.BackColor = System.Drawing.Color.Transparent;
            this.amblemeklepcbx.Location = new System.Drawing.Point(332, 34);
            this.amblemeklepcbx.Name = "amblemeklepcbx";
            this.amblemeklepcbx.Size = new System.Drawing.Size(164, 153);
            this.amblemeklepcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amblemeklepcbx.TabIndex = 9;
            this.amblemeklepcbx.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MacEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amblemeklepcbx);
            this.Controls.Add(this.btnmacekle);
            this.Controls.Add(this.btnamblem1);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrakip1);
            this.Controls.Add(this.rkp1);
            this.DoubleBuffered = true;
            this.Name = "MacEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacEkle";
            this.Load += new System.EventHandler(this.MacEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amblemeklepcbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rkp1;
        private System.Windows.Forms.TextBox txtrakip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnamblem1;
        private System.Windows.Forms.Button btnmacekle;
        private System.Windows.Forms.PictureBox amblemeklepcbx;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpicker;
    }
}