namespace MacBiletiOtomasyon
{
    partial class FiyatGuncelle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiyatGuncelle));
            this.fiyatListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mac_BiletiDataSet1 = new MacBiletiOtomasyon.Mac_BiletiDataSet1();
            this.macEkleDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.macEkleData = new MacBiletiOtomasyon.MacEkleData();
            this.dataSet1 = new MacBiletiOtomasyon.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.macEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.macEkleTableAdapter = new MacBiletiOtomasyon.MacEkleDataTableAdapters.MacEkleTableAdapter();
            this.fiyatListesiTableAdapter = new MacBiletiOtomasyon.Mac_BiletiDataSet1TableAdapters.FiyatListesiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucretgunceltxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.konumgunceltctbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlstele = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mac_BiletiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macEkleDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macEkleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macEkleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fiyatListesiBindingSource
            // 
            this.fiyatListesiBindingSource.DataMember = "FiyatListesi";
            this.fiyatListesiBindingSource.DataSource = this.mac_BiletiDataSet1;
            // 
            // mac_BiletiDataSet1
            // 
            this.mac_BiletiDataSet1.DataSetName = "Mac_BiletiDataSet1";
            this.mac_BiletiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // macEkleDataBindingSource
            // 
            this.macEkleDataBindingSource.DataSource = this.macEkleData;
            this.macEkleDataBindingSource.Position = 0;
            // 
            // macEkleData
            // 
            this.macEkleData.DataSetName = "MacEkleData";
            this.macEkleData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // macEkleBindingSource
            // 
            this.macEkleBindingSource.DataMember = "MacEkle";
            this.macEkleBindingSource.DataSource = this.macEkleDataBindingSource;
            // 
            // macEkleTableAdapter
            // 
            //this.macEkleTableAdapter.ClearBeforeFill = true;
            // 
            // fiyatListesiTableAdapter
            // 
            this.fiyatListesiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Location = new System.Drawing.Point(66, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ucretgunceltxtbx
            // 
            this.ucretgunceltxtbx.Location = new System.Drawing.Point(137, 159);
            this.ucretgunceltxtbx.Multiline = true;
            this.ucretgunceltxtbx.Name = "ucretgunceltxtbx";
            this.ucretgunceltxtbx.Size = new System.Drawing.Size(217, 34);
            this.ucretgunceltxtbx.TabIndex = 2;
            this.ucretgunceltxtbx.TextChanged += new System.EventHandler(this.ucretgunceltxtbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(44, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "KONUM:";
            // 
            // konumgunceltctbx
            // 
            this.konumgunceltctbx.Location = new System.Drawing.Point(137, 103);
            this.konumgunceltctbx.Multiline = true;
            this.konumgunceltctbx.Name = "konumgunceltctbx";
            this.konumgunceltctbx.Size = new System.Drawing.Size(217, 34);
            this.konumgunceltctbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(47, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "ÜCRET:";
            // 
            // btnlstele
            // 
            this.btnlstele.BackColor = System.Drawing.Color.Silver;
            this.btnlstele.Location = new System.Drawing.Point(830, 29);
            this.btnlstele.Name = "btnlstele";
            this.btnlstele.Size = new System.Drawing.Size(114, 148);
            this.btnlstele.TabIndex = 6;
            this.btnlstele.Text = "LİSTELE";
            this.btnlstele.UseVisualStyleBackColor = false;
            this.btnlstele.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Silver;
            this.btnkaydet.Location = new System.Drawing.Point(692, 29);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(114, 148);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.BackColor = System.Drawing.Color.Silver;
            this.guncellebtn.Location = new System.Drawing.Point(560, 29);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(114, 148);
            this.guncellebtn.TabIndex = 8;
            this.guncellebtn.Text = "GÜNCELLE";
            this.guncellebtn.UseVisualStyleBackColor = false;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.BackColor = System.Drawing.Color.Silver;
            this.silbtn.Location = new System.Drawing.Point(428, 29);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(114, 148);
            this.silbtn.TabIndex = 9;
            this.silbtn.Text = "SİL";
            this.silbtn.UseVisualStyleBackColor = false;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(137, 44);
            this.txtNo.Multiline = true;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(217, 34);
            this.txtNo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(-7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "MÜŞTERİ NO:";
            // 
            // FiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(987, 631);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnlstele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.konumgunceltctbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucretgunceltxtbx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FiyatGuncelle";
            this.Text = "FiyatGuncelle";
            this.Load += new System.EventHandler(this.FiyatGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mac_BiletiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macEkleDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macEkleData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.macEkleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource macEkleDataBindingSource;
        private MacEkleData macEkleData;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource macEkleBindingSource;
        //private MacEkleDataTableAdapters.MacEkleTableAdapter macEkleTableAdapter;
        private Mac_BiletiDataSet1 mac_BiletiDataSet1;
        private System.Windows.Forms.BindingSource fiyatListesiBindingSource;
        private Mac_BiletiDataSet1TableAdapters.FiyatListesiTableAdapter fiyatListesiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox konumgunceltctbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlstele;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox ucretgunceltxtbx;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}