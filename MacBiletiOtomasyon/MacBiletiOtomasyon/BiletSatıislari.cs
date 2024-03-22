using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacBiletiOtomasyon
{
    public partial class BiletSatıislari : Form
    {
        public BiletSatıislari()
        {
            InitializeComponent();
            DatagridviewSettings(biletsatisdtgrid);
        }
        private void DatagridviewSettings(DataGridView dta)
        {
            dta.RowHeadersVisible = false;
            dta.BorderStyle = BorderStyle.None;
        
          
            dta.DefaultCellStyle.SelectionForeColor = Color.White;
            dta.EnableHeadersVisualStyles = false;
            dta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }
        SqlConnection connection = new SqlConnection(Baglanti.baglanti);

        private void BiletSatıislari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mac_BiletiDataSet3.BiletSatis' table. You can move, or remove it, as needed.
            // this.biletSatisTableAdapter.Fill(this.mac_BiletiDataSet3.BiletSatis);
            connection.Open();
            string command = "select *from BiletSatis Order By Id";
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            biletsatisdtgrid.DataSource = dataTable;



        }

        private void biletsatisdtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
