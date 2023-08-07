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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hareketler
{
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TFCL3EH;Initial Catalog=Hareket;Integrated Security=True");
        string connectionString = "Data Source=DESKTOP-TFCL3EH;Initial Catalog=Hareket;Integrated Security=True";
        private DataTable originalData = new DataTable();
        public void VerileriGuncelle()
        {
            string query = "SELECT ID, AD, STOK, ALISFIYAT, SATISFIYAT FROM URUNLER";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dataGridView1.DataSource = dt;

                    reader.Close();
                }
            }
        }
        private void ComboboxYenile()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, AD, STOK, ALISFIYAT, SATISFIYAT FROM URUNLER";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = dt;

            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "AD";
            comboBox2.DataSource = dt;
        }
        private void VeritabaniYenile()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID, AD, STOK, ALISFIYAT, SATISFIYAT FROM URUNLER";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

                connection.Close();
            }
        }
        private void UrunEkleme_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select ID,AD,STOK,ALISFIYAT,SATISFIYAT From URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "AD";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = dt;
            dataGridView1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("Select ID,AD,STOK,ALISFIYAT,SATISFIYAT From URUNLER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.ValueMember = "AD";
            comboBox2.DisplayMember = "AD";
            comboBox2.DataSource = dt2;
            dataGridView1.DataSource = dt2;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string arananIsim = txturunara.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID, AD FROM URUNLER WHERE AD LIKE @ArananIsim";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ArananIsim", "%" + arananIsim + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.ClearSelection();
                        MessageBox.Show("Bulundu, diğer verilerin görünmesini istiyorsanız yandaki yenile butonuna basınız.");
                    }
                    else
                    {
                        MessageBox.Show("Bulunamadı");
                    }
                }

                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VeritabaniYenile();
        }

        private void btnurunsil_Click(object sender, EventArgs e)
        {
            string selectedProductName = comboBox2.Text;

            if (string.IsNullOrEmpty(selectedProductName))
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir ürünü seçin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM URUNLER WHERE AD = @Ad";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", selectedProductName);

                        command.ExecuteNonQuery();
                    }

                    VerileriGuncelle();
                    ComboboxYenile();
                    MessageBox.Show("Ürün başarıyla silindi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }


        private void btnurunkle_Click(object sender, EventArgs e)
        {
            string ad = txturunad.Text;
            int stok = Convert.ToInt32(txturunstok.Text);
            decimal alisFiyat = Convert.ToDecimal(txturunalisfiyat.Text);
            decimal satisFiyat = Convert.ToDecimal(txturunsatisfiyat.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO URUNLER (AD, STOK, ALISFIYAT, SATISFIYAT) VALUES (@AD, @STOK, @ALISFIYAT, @SATISFIYAT)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AD", ad);
                        command.Parameters.AddWithValue("@STOK", stok);
                        command.Parameters.AddWithValue("@ALISFIYAT", alisFiyat);
                        command.Parameters.AddWithValue("@SATISFIYAT", satisFiyat);

                        command.ExecuteNonQuery();
                    }
                    VerileriGuncelle();
                    ComboboxYenile();
                    MessageBox.Show("Veri başarıyla ekleni.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnurunguncelle_Click(object sender, EventArgs e)
        {
            string selectedProductName = comboBox1.Text;

            if (string.IsNullOrEmpty(selectedProductName))
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir ürünü seçin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE URUNLER SET AD = @AD, STOK = @STOK, ALISFIYAT = @ALISFIYAT, SATISFIYAT = @SATISFIYAT WHERE AD = @SelectedAD";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AD", txtyeniurunad.Text);
                        command.Parameters.AddWithValue("@STOK", Convert.ToInt32(txtyenistok.Text));
                        command.Parameters.AddWithValue("@ALISFIYAT", Convert.ToDecimal(txtyenialisfiyat.Text));
                        command.Parameters.AddWithValue("@SATISFIYAT", Convert.ToDecimal(txtyenisatisfiyat.Text));
                        command.Parameters.AddWithValue("@SelectedAD", selectedProductName);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            VerileriGuncelle();
                            ComboboxYenile();
                            MessageBox.Show("Ürün başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme işlemi başarısız oldu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("AD", typeof(string));
            dt.Columns.Add("stok", typeof(int));
            dt.Columns.Add("alisfiyat", typeof(decimal));
            dt.Columns.Add("satisfiyat", typeof(decimal));

            DataRow row = dt.NewRow();
            row["AD"] = "Ürün Adı";
            row["stok"] = 10;
            row["alisfiyat"] = 100.50m;
            row["satisfiyat"] = 150.00m;
            dt.Rows.Add(row);

            if (comboBox1.SelectedIndex != -1)
            {
                string secilenUrun = comboBox1.SelectedItem.ToString();
                DataRow[] rows = dt.Select("AD = '" + secilenUrun + "'");

                if (rows.Length > 0)
                {
                    string ad = rows[0]["AD"].ToString();
                    string stok = rows[0]["stok"].ToString();
                    string alisFiyat = rows[0]["alisfiyat"].ToString();
                    string satisFiyat = rows[0]["satisfiyat"].ToString();

                    txtyeniurunad.Text = ad;
                    txtyenistok.Text = stok;
                    txtyenialisfiyat.Text = alisFiyat;
                    txtyenisatisfiyat.Text = satisFiyat;
                }
            }
        }
    }
}
