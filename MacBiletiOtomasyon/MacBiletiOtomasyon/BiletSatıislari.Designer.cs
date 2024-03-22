namespace MacBiletiOtomasyon
{
    partial class BiletSatıislari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.biletsatisdtgrid = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rakipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mac_BiletiDataSet3 = new MacBiletiOtomasyon.Mac_BiletiDataSet3();
            this.biletSatisTableAdapter = new MacBiletiOtomasyon.Mac_BiletiDataSet3TableAdapters.BiletSatisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.biletsatisdtgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletSatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mac_BiletiDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // biletsatisdtgrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.biletsatisdtgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.biletsatisdtgrid.AutoGenerateColumns = false;
            this.biletsatisdtgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.biletsatisdtgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.biletsatisdtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.biletsatisdtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.rakipDataGridViewTextBoxColumn,
            this.konumDataGridViewTextBoxColumn,
            this.bolgeDataGridViewTextBoxColumn,
            this.koltukDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.biletsatisdtgrid.DataSource = this.biletSatisBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.biletsatisdtgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.biletsatisdtgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biletsatisdtgrid.Location = new System.Drawing.Point(0, 0);
            this.biletsatisdtgrid.Name = "biletsatisdtgrid";
            this.biletsatisdtgrid.RowHeadersWidth = 51;
            this.biletsatisdtgrid.RowTemplate.Height = 40;
            this.biletsatisdtgrid.RowTemplate.ReadOnly = true;
            this.biletsatisdtgrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.biletsatisdtgrid.Size = new System.Drawing.Size(1039, 531);
            this.biletsatisdtgrid.TabIndex = 0;
            this.biletsatisdtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.biletsatisdtgrid_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // rakipDataGridViewTextBoxColumn
            // 
            this.rakipDataGridViewTextBoxColumn.DataPropertyName = "Rakip";
            this.rakipDataGridViewTextBoxColumn.HeaderText = "Rakip";
            this.rakipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rakipDataGridViewTextBoxColumn.Name = "rakipDataGridViewTextBoxColumn";
            this.rakipDataGridViewTextBoxColumn.Width = 125;
            // 
            // konumDataGridViewTextBoxColumn
            // 
            this.konumDataGridViewTextBoxColumn.DataPropertyName = "Konum";
            this.konumDataGridViewTextBoxColumn.HeaderText = "Konum";
            this.konumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konumDataGridViewTextBoxColumn.Name = "konumDataGridViewTextBoxColumn";
            this.konumDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolgeDataGridViewTextBoxColumn
            // 
            this.bolgeDataGridViewTextBoxColumn.DataPropertyName = "Bolge";
            this.bolgeDataGridViewTextBoxColumn.HeaderText = "Bolge";
            this.bolgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolgeDataGridViewTextBoxColumn.Name = "bolgeDataGridViewTextBoxColumn";
            this.bolgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // koltukDataGridViewTextBoxColumn
            // 
            this.koltukDataGridViewTextBoxColumn.DataPropertyName = "Koltuk";
            this.koltukDataGridViewTextBoxColumn.HeaderText = "Koltuk";
            this.koltukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.koltukDataGridViewTextBoxColumn.Name = "koltukDataGridViewTextBoxColumn";
            this.koltukDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // biletSatisBindingSource
            // 
            this.biletSatisBindingSource.DataMember = "BiletSatis";
            this.biletSatisBindingSource.DataSource = this.mac_BiletiDataSet3;
            // 
            // mac_BiletiDataSet3
            // 
            this.mac_BiletiDataSet3.DataSetName = "Mac_BiletiDataSet3";
            this.mac_BiletiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletSatisTableAdapter
            // 
            this.biletSatisTableAdapter.ClearBeforeFill = true;
            // 
            // BiletSatıislari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 531);
            this.Controls.Add(this.biletsatisdtgrid);
            this.Name = "BiletSatıislari";
            this.Text = "BiletSatıislari";
            this.Load += new System.EventHandler(this.BiletSatıislari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletsatisdtgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletSatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mac_BiletiDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Mac_BiletiDataSet3 mac_BiletiDataSet3;
        private System.Windows.Forms.BindingSource biletSatisBindingSource;
        private Mac_BiletiDataSet3TableAdapters.BiletSatisTableAdapter biletSatisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rakipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView biletsatisdtgrid;
    }
}