    using DevExpress.ClipboardSource.SpreadsheetML;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static DevExpress.XtraEditors.Mask.MaskSettings;

    namespace MacBiletiOtomasyon
    {  
        public partial class AnaSayfa : Form
        {
       



            public AnaSayfa()
            {
                InitializeComponent();
            
            }
       

       
     
            SqlCommand cmd = new SqlCommand();


        


        
            private void getir(ComboBox combo, string sq1, string sql2)

            {
                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);


                baglanti.Open();
                SqlCommand komut = new SqlCommand(sq1, baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    cmboboxrakip1.Items.Add(read[sql2].ToString());
                }
                baglanti.Close();
            }

            private void AmblemGetir()
            {

                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from MacEkle3 where Rakip ='"+cmboboxrakip1.SelectedItem+"'",baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    eklenmispcbx.ImageLocation = read["Amblem"].ToString();
                }
                baglanti.Close();
            }

       
            private void Form1_Load(object sender, EventArgs e)
            {

                getir(cmboboxrakip1, "select *from MacEkle3", "Rakip");
                AmblemGetir();
                cmboboxrakip1.Items.Remove("sss");
                cmboboxrakip1.Items.Remove("sss");
                cmboboxrakip1.Items.Remove("");
            








                for (int i = 115; i < 120; i++) konumseccmbx.Items.Add("GÜNEY KALE ARKASI-" + i);
                for (int i = 124; i <= 129; i++) konumseccmbx.Items.Add("TOFAŞ TRİBÜNÜ-" + i);
                for (int i = 130; i <= 133; i++) konumseccmbx.Items.Add("DOĞU ÜST TRİBÜN-" + i);
                for (int i = 112; i <= 114; i++) konumseccmbx.Items.Add("DOĞU ALT TRİBÜN-" + i);
                for (int i = 121; i <= 123; i++) konumseccmbx.Items.Add("BATI ALT TRİBÜN-" + i);


            
                konumseccmbx.Items.Add("123-A");
                konumseccmbx.Items.Add("121-B");
                konumseccmbx.Items.Add("PROTOKOL");
                konumseccmbx.Items.Add("BASIN");

           




          
           
           
            }
       
            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {
           

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void button8_Click(object sender, EventArgs e)
            {
           
            }

            private void button9_Click(object sender, EventArgs e)
            {

            }

            private void button13_Click(object sender, EventArgs e)
            {

            }

            private void button5_Click(object sender, EventArgs e)
            {

            }

            private void button14_Click(object sender, EventArgs e)
            {

            }

            private void button10_Click(object sender, EventArgs e)
            {

            }

            private void button12_Click(object sender, EventArgs e)
            {

            }

            private void button11_Click(object sender, EventArgs e)
            {

            }

            private void button20_Click(object sender, EventArgs e)
            {

            }

            private void bttn115_Click(object sender, EventArgs e)
            {

            }

            private void bttnmacekle_Click(object sender, EventArgs e)
            {
           
                MacEkle macEkle = new MacEkle();
                macEkle.Show();
            }

            private void cmboboxrakip1_SelectedIndexChanged(object sender, EventArgs e)
            {
           
                AmblemGetir();




            }

            private void pictureBox4_Click(object sender, EventArgs e)
            {
           
            }

            private void pcbx3_Click(object sender, EventArgs e)
            {

            }

            private void pcbx2_Click(object sender, EventArgs e)
            {
            
            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
           

           
            }
        
            private void bolgecmbx_SelectedIndexChanged(object sender, EventArgs e)
            {
                for(int j =112; j<=133; j++)
                {
                    if (bolgecmbx.Text == j+"-SAHAYA YAKIN")
                    {
                        kotukseccmbx.Items.Clear();
                        for (int i = 1; i <= 50; i++) kotukseccmbx.Items.Add(j+"(Bölge)-" + i + "(Koltuk no)");


                    }
                    else if (bolgecmbx.Text == j+"-ORTA KISIM")
                    {
                        kotukseccmbx.Items.Clear();
                        for (int i = 51; i <= 100; i++) kotukseccmbx.Items.Add(j + "(Bölge)-" + i + "(Koltuk no)");
                    }
                    else if (bolgecmbx.Text == j+"-ARKA KISIM")
                    {
                        kotukseccmbx.Items.Clear();
                        for (int i = 101; i <= 150; i++) kotukseccmbx.Items.Add(j + "(Bölge)-" + i + "(Koltuk no)");
                    }

                }

                if (bolgecmbx.Text == "123-A-SAHAYA YAKIN")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 1; i <= 50; i++) kotukseccmbx.Items.Add("123-A(Bölge)-" + i + "(Koltuk no)");


                }
                else if (bolgecmbx.Text == "123-A-ORTA KISIM")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 51; i <= 100; i++) kotukseccmbx.Items.Add("123-A(Bölge)-" + i + "(Koltuk no)");
                }
                else if (bolgecmbx.Text == "123-A-ARKA KISIM")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 101; i <= 150; i++) kotukseccmbx.Items.Add("123-A(Bölge)-" + i + "(Koltuk no)");
                }



                else if (bolgecmbx.Text == "121-B-SAHAYA YAKIN")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 1; i <= 50; i++) kotukseccmbx.Items.Add("121-B(Bölge)-" + i + "(Koltuk no)");


                }
                else if (bolgecmbx.Text == "121-B-ORTA KISIM")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 51; i <= 100; i++) kotukseccmbx.Items.Add("121-B(Bölge)-" + i + "(Koltuk no)");
                }
                else if (bolgecmbx.Text == "121-B-ARKA KISIM")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 101; i <= 150; i++) kotukseccmbx.Items.Add("121-B(Bölge)-" + i + "(Koltuk no)");
                }

                else if (bolgecmbx.Text == "BASIN-SAHAYA YAKIN")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 1; i <= 50; i++) kotukseccmbx.Items.Add("BASIN(Bölge)-" + i + "(Koltuk no)");
                }
                else if (bolgecmbx.Text == "BASIN-ORTA KISIM")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 51; i <= 100; i++) kotukseccmbx.Items.Add("BASIN(Bölge)-" + i + "(Koltuk no)");
                }
                else if (bolgecmbx.Text == "BASIN-ARKA KISIM")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 101; i <= 150; i++) kotukseccmbx.Items.Add("BASIN(Bölge)-" + i + "(Koltuk no)");
                }


                else if (bolgecmbx.Text == "PROTOKOL-SAHAYA YAKIN")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 1; i <= 50; i++) kotukseccmbx.Items.Add("PROTOKOL(Bölge)-" + i + "(Koltuk no)");
                }
                else if (bolgecmbx.Text == "PROTOKOL-ORTA KISIM")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 51; i <= 100; i++) kotukseccmbx.Items.Add("PROTOKOL(Bölge)-" + i + "(Koltuk no)");
                }
                else if (bolgecmbx.Text == "PROTOKOL-ARKA KISIM")
                {
                    kotukseccmbx.Items.Clear();
                    for (int i = 101; i <= 150; i++) kotukseccmbx.Items.Add("PROTOKOL(Bölge)-" + i + "(Koltuk no)");
                }



            }

            private void konumseccmbx_SelectedIndexChanged(object sender, EventArgs e)
            {
                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);

                sahapanel.Visible = true;

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                string kayit = "select *from FiyatListesi where Konum_Adi like '" + konumseccmbx.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                SqlDataReader read = komut.ExecuteReader();

                while (read.Read())
                {
                    ucrettextbox.Text = read["Ucret"].ToString();
                }
                baglanti.Close();


                for (int i = 115; i <=120 ; i++)
                {
                      if (konumseccmbx.Text == "GÜNEY KALE ARKASI-"+i)
                    {

                        bolgecmbx.Items.Clear();
                        bolgecmbx.Items.Add(i+"-SAHAYA YAKIN");
                        bolgecmbx.Items.Add(i+"-ORTA KISIM");
                        bolgecmbx.Items.Add(i+"-ARKA KISIM");

                    }

                }
                for(int i =124; i<=129; i++)
                {
                    if (konumseccmbx.Text == "TOFAŞ TRİBÜNÜ-" + i)
                    {

                        bolgecmbx.Items.Clear();
                        bolgecmbx.Items.Add(i + "-SAHAYA YAKIN");
                        bolgecmbx.Items.Add(i + "-ORTA KISIM");
                        bolgecmbx.Items.Add(i + "-ARKA KISIM");

                    }
                }
                for (int i = 112; i <= 114; i++)
                {
                    if (konumseccmbx.Text == "DOĞU ALT TRİBÜN-" + i)
                    {

                        bolgecmbx.Items.Clear();
                        bolgecmbx.Items.Add(i + "-SAHAYA YAKIN");
                        bolgecmbx.Items.Add(i + "-ORTA KISIM");
                        bolgecmbx.Items.Add(i + "-ARKA KISIM");

                    }
                }
                for (int i = 130; i <= 133; i++)
                {
                    if (konumseccmbx.Text == "DOĞU ÜST TRİBÜN-" + i)
                    {

                        bolgecmbx.Items.Clear();
                        bolgecmbx.Items.Add(i + "-SAHAYA YAKIN");
                        bolgecmbx.Items.Add(i + "-ORTA KISIM");
                        bolgecmbx.Items.Add(i + "-ARKA KISIM");

                    }

                }
                for (int i = 121; i <= 123; i++)
                {
                    if (konumseccmbx.Text == "BATI ALT TRİBÜN-" + i)
                    {

                        bolgecmbx.Items.Clear();
                        bolgecmbx.Items.Add(i + "-SAHAYA YAKIN");
                        bolgecmbx.Items.Add(i + "-ORTA KISIM");
                        bolgecmbx.Items.Add(i + "-ARKA KISIM");

                    }

                }

                if (konumseccmbx.Text == "123-A")
                {

                    bolgecmbx.Items.Clear();
                    bolgecmbx.Items.Add("123-A-SAHAYA YAKIN");
                    bolgecmbx.Items.Add("123-A-ORTA KISIM");
                    bolgecmbx.Items.Add("123-A-ARKA KISIM");

                }
                if (konumseccmbx.Text == "123-B")
                {

                    bolgecmbx.Items.Clear();
                    bolgecmbx.Items.Add("123-B-SAHAYA YAKIN");
                    bolgecmbx.Items.Add("123-B-ORTA KISIM");
                    bolgecmbx.Items.Add("123-B-ARKA KISIM");

                }
                if (konumseccmbx.Text == "BASIN")
                {

                    bolgecmbx.Items.Clear();
                    bolgecmbx.Items.Add("BASIN-SAHAYA YAKIN");
                    bolgecmbx.Items.Add("BASIN--ORTA KISIM");
                    bolgecmbx.Items.Add("BASIN--ARKA KISIM");

                }
                if (konumseccmbx.Text == "PROTOKOL")
                {

                    bolgecmbx.Items.Clear();
                    bolgecmbx.Items.Add("PROTOKOL-SAHAYA YAKIN");
                    bolgecmbx.Items.Add("PROTOKOL-ORTA KISIM");
                    bolgecmbx.Items.Add("PROTOKOL-ARKA KISIM");

                }






            }

            private void kotukseccmbx_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void btnbiletfiyatgoruntule_Click(object sender, EventArgs e)
            {
                FiyatGuncelle ff = new FiyatGuncelle();
                ff.Show();
            }

            private void ucrettextbox_TextChanged(object ucret, EventArgs e)
            {
            

            }

            private void konumseccmbx_MouseEnter(object sender, EventArgs e)
            {
           
            
            }

            private void btnsatilanbiletler_Click(object sender, EventArgs e)
            {
                BiletSatıislari satis = new BiletSatıislari();
                satis.Show();
            }

            private void button1_Click_1(object sender, EventArgs e)
            {
                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);



                if (cmboboxrakip1.Items.Count==0 || konumseccmbx.Items.Count == 0 || bolgecmbx.Items.Count == 0 || adtextbx.Text == "" ||
                   soyadtxtbx.Text == "" || ucrettextbox.Text == "")
                {
                    MessageBox.Show("Lütfen boş olan yerleri doldurunuz", "Eksik seçim");
                }


                else
                {

           

                try
                        {
               
                    if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();
                            string kayit = "insert into BiletSatis(Rakip,Konum,Bolge,Koltuk,Ad,Soyad,Ucret,Tarih)values(@Rakip,@Konum,@Bolge,@Koltuk,@Ad,@Soyad,@Ucret,@Tarih)";
                            SqlCommand komut = new SqlCommand(kayit, baglanti);
                            komut.Parameters.AddWithValue("@Rakip", cmboboxrakip1.Text);
                            komut.Parameters.AddWithValue("@Konum", konumseccmbx.Text);
                            komut.Parameters.AddWithValue("@Bolge", bolgecmbx.Text);
                            komut.Parameters.AddWithValue("@Koltuk", kotukseccmbx.Text);
                            komut.Parameters.AddWithValue("@Ad", adtextbx.Text);
                            komut.Parameters.AddWithValue("@Soyad", soyadtxtbx.Text);
                            komut.Parameters.AddWithValue("@Ucret", ucrettextbox.Text);
                            komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));


                        komut.ExecuteNonQuery();
                            MessageBox.Show("Kayıtlar Eklendi", "Kayıt Ekleme");

                        }
                        catch (Exception hata)
                        {

                            MessageBox.Show("Hata!", hata.Message);
                            MessageBox.Show(hata.Message);


                    }
                }


                koltukiptalcmbx.Text = null;
           
            
                DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select *from BiletSatis", baglanti);
                    da.Fill(dataTable);
                    koltukiptalcmbx.ValueMember = "Koltuk";
                    koltukiptalcmbx.DataSource = dataTable;
                    baglanti.Close();
                }



          
        
             SqlCommand komut;
            public void KayitlariGetir()
            {
                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);

                BiletSatıislari bs = new BiletSatıislari();
                string getir = "select *from BiletSatis";
                SqlCommand komut = new SqlCommand(getir, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adptr.Fill(dt);
                bs.biletsatisdtgrid.DataSource = dt;
                baglanti.Close();
            }
            private void button2_Click_1(object sender, EventArgs e)
            {
                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);
                if (koltukiptalcmbx.Items.Count==0)
            {
                MessageBox.Show("İptal edilecek koltuk yok!");
                }
                else
                {
                    try
                    {
                        string sorgu = ("DELETE FROM BiletSatis WHERE Koltuk=@Koltuk");
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Koltuk", koltukiptalcmbx.Text);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        KayitlariGetir();
                  
                        MessageBox.Show("Bilet iptal edildi");
                        if (koltukiptalcmbx.Items.Count == 0)
                        {
                            koltukiptalcmbx.Items.Clear();


                    }
                }
                    catch (Exception hata)

                    {
                        MessageBox.Show("Sorun oluştu! " + hata.Message);
                    

                    }

                

                baglanti.Close();


                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select *from BiletSatis", baglanti);
                    da.Fill(dataTable);
                    koltukiptalcmbx.ValueMember = "Koltuk";
                    koltukiptalcmbx.DataSource = dataTable;

                }
           
           


            }

            private void koltukiptalcmbx_SelectedIndexChanged(object sender, EventArgs e)
            {
           
            }

            private void button1_MouseEnter(object sender, EventArgs e)
            {
           
            }

            private void btnguncelle_Click(object sender, EventArgs e)
            {
            
            
            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void kotukseccmbx_SelectedIndexChanged_1(object sender, EventArgs e)
            {
           
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void pcbx10_Click(object sender, EventArgs e)
            {

            }

            private void kotukseccmbx_DrawItem(object sender, DrawItemEventArgs e)
            {

            

            }
        }
    }
