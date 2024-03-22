using MacBiletiOtomasyon.MacEkleDataTableAdapters;
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
    public partial class MacEkle : Form
    {
        public MacEkle()
        {
            InitializeComponent();
        }

        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnamblem1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            amblemeklepcbx.ImageLocation = openFileDialog1.FileName;
        }

       
        private void btnmacekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);


            if (txtrakip1.Text=="" || amblemeklepcbx.Image == null)
            {
                MessageBox.Show("Lütfen boş yerleri doldurunuz");
            }

            else
            {
                try
   
                
                { 
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        string ekle = "INSERT INTO MacEkle3 (Rakip,Tarih,Amblem) values (@Rakip,@Tarih,@Amblem)";
                        SqlCommand komut = new SqlCommand(ekle, baglanti);
                        komut.Parameters.AddWithValue("@Rakip", txtrakip1.Text);
                        komut.Parameters.AddWithValue("@Tarih", dtpicker.Text);
                        komut.Parameters.AddWithValue("@Amblem", amblemeklepcbx.ImageLocation);
                        komut.ExecuteNonQuery();
                      

                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show("Hata!", hata.Message);
                    }

                    //ekle.MacEkle3(txtrakip1.Text, dtpicker.Text, amblemeklepcbx.ImageLocation);



                    MessageBox.Show("Yeni Maç Eklendi", "Maç Ekleme");
                }
                catch (Exception)
                {

                    MessageBox.Show("Bu maç daha önce eklendi", "UYARI!");
                }

                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            }
           
        }


        private void txtrakip1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MacEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
