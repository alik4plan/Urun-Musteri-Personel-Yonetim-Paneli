using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hareketler
{
    public partial class Ürün : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TFCL3EH;Initial Catalog=Hareket;Integrated Security=True");
        string connectionString = "Data Source=DESKTOP-TFCL3EH;Initial Catalog=Hareket;Integrated Security=True";
        public Ürün()
        {
            InitializeComponent();
        }

        public void ComboboxYenile()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT HAREKETID, URUN, MUSTERI, PERSONEL, FIYAT FROM HAREKETLER";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            cbxsil.DisplayMember = "HAREKETID";
            cbxsil.DataSource = dt;
        }
        private void HareketleriGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT HAREKETID, URUN, MUSTERI, PERSONEL, FIYAT FROM HAREKETLER";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT ID, Ad FROM URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Ad";
            comboBox1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("SELECT ID, ADSOYAD FROM MUSTERILER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "ADSOYAD";
            comboBox2.DataSource = dt2;

            SqlCommand komut3 = new SqlCommand("SELECT ID, AD FROM PERSONELLER", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox3.ValueMember = "ID";
            comboBox3.DisplayMember = "AD";
            comboBox3.DataSource = dt3;

            SqlCommand komut4 = new SqlCommand("SELECT HAREKETID, URUN FROM HAREKETLER", baglanti);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cbxsil.ValueMember = "HAREKETID";
            cbxsil.DisplayMember = "HAREKETID";
            cbxsil.DataSource = dt4;
            HareketleriGetir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunEkleme urunEkleme = new UrunEkleme();
            urunEkleme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriEkleme musteriEkleme = new MusteriEkleme();
            musteriEkleme.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelEkleme personelEkleme = new PersonelEkleme();
            personelEkleme.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int urunID = Convert.ToInt32(comboBox1.SelectedValue);
                int musteriID = Convert.ToInt32(comboBox2.SelectedValue);
                int personelID = Convert.ToInt32(comboBox3.SelectedValue);
                decimal fiyat = Convert.ToDecimal(txtfiyat.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO HAREKETLER (URUN, MUSTERI, PERSONEL, FIYAT) VALUES (@UrunID, @MusteriID, @PersonelID, @Fiyat)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UrunID", urunID);
                        command.Parameters.AddWithValue("@MusteriID", musteriID);
                        command.Parameters.AddWithValue("@PersonelID", personelID);
                        command.Parameters.AddWithValue("@Fiyat", fiyat);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            ComboboxYenile();
                            HareketleriGetir();
                            MessageBox.Show("Satış başarıyla eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Satış eklenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void satissil_Click(object sender, EventArgs e)
        {
            string selectedProductName = cbxsil.Text;

            if (string.IsNullOrEmpty(selectedProductName))
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir satışı seçin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM HAREKETLER WHERE HAREKETID = @Hareketid";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Hareketid", selectedProductName);

                        command.ExecuteNonQuery();
                    }
                    ComboboxYenile();
                    HareketleriGetir();
                    MessageBox.Show("Satış başarıyla silindi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
    }
}

