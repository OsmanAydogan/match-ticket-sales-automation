using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace MacBiletiOtomasyon
{
    public partial class FiyatGuncelle : Form
    {
        SqlCommand komut;




        
       

        public FiyatGuncelle()
        {
            InitializeComponent();
            DatagridviewSettings(dataGridView1);
        }

     

        

        

        private void FiyatGuncelle_Load(object sender, EventArgs e)
        {
           
            
          

        }

        public void KayitlariGetir()
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);

            string getir = "select *from FiyatListesi";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter adptr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }


        private void label5_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

           

        }

        private void misafirfiyattxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void misafirguncelletxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void guncellebttn_Click(object sender, EventArgs e)
        {   
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);
            if (konumgunceltctbx.Text=="" || ucretgunceltxtbx.Text == "")
            {
                MessageBox.Show("Lütfen boş yerleri doldurunuz");
            }

            else { 
            try
            {   if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into FiyatListesi(Konum_Adi,Ucret)values(@Konumadi,@Ucret)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@Konumadi", konumgunceltctbx.Text);
                komut.Parameters.AddWithValue("@Ucret", ucretgunceltxtbx.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıtlar Eklendi", "Kayıt Ekleme");

            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!", hata.Message);
            }
        }
        }
        private void guncellebtn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);
            string kayitguncelle = ("Update FiyatListesi Set Konum_Adi=@Konumadi,Ucret=@ucret Where Id=@id");
            
             komut = new SqlCommand(kayitguncelle, baglanti) ;
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtNo.Text));
            komut.Parameters.AddWithValue("@Konumadi", konumgunceltctbx.Text);
            komut.Parameters.AddWithValue("@ucret", ucretgunceltxtbx.Text);
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitlariGetir();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            konumgunceltctbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ucretgunceltxtbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);

            string sorgu = ("DELETE FROM FiyatListesi WHERE Id=@Id");
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", Convert.ToInt32(txtNo.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            KayitlariGetir();
            baglanti.Close();
        }

        private void ucretgunceltxtbx_TextChanged(object sender, EventArgs e)
        {

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
          


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
