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

namespace Hareketler
{
    public partial class PersonelEkleme : Form
    {
        public PersonelEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TFCL3EH;Initial Catalog=Hareket;Integrated Security=True");
        string connectionString = "Data Source=DESKTOP-TFCL3EH;Initial Catalog=Hareket;Integrated Security=True";
        private DataTable originalData = new DataTable();
        public void VerileriGuncelle()
        {
            string query = "SELECT ID, AD FROM PERSONELLER";

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
                string query = "SELECT ID, AD FROM PERSONELLER";
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

                string selectQuery = "SELECT ID, AD FROM PERSONELLER";
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
        private void PersonelEkleme_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select ID,AD From PERSONELLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "AD";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = dt;
            dataGridView1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("Select ID,AD From PERSONELLER", baglanti);
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
            string arananIsim = txtpersonelara.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID, AD FROM PERSONELLER WHERE AD LIKE @ArananIsim";
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

        private void btnpersonsil_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM PERSONELLER WHERE AD = @Value";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", comboBox2.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        VerileriGuncelle();
                        ComboboxYenile();
                        MessageBox.Show("Personel başarıyla silindi.");
                        string updateIdentityQuery = "DBCC CHECKIDENT('PERSONELLER', RESEED)";
                        using (SqlCommand updateIdentityCommand = new SqlCommand(updateIdentityQuery, connection))
                        {
                            connection.Open();
                            updateIdentityCommand.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız oldu. Seçili personel bulunamadı.");
                    }
                }
            }
        }


        private void btnpersonekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string yeniVeri = txtpersonekle.Text;

                connection.Open();

                string insertQuery = "INSERT INTO PERSONELLER (AD) VALUES (@Veri)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Veri", yeniVeri);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            VerileriGuncelle();
                            ComboboxYenile();
                            MessageBox.Show("Personel başarıyla eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Personel eklenirken bir hata oluştu. Veri eklenmedi.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Personel eklenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void btnpersonguncelle_Click(object sender, EventArgs e)
        {
            string eskiAd = comboBox1.SelectedValue.ToString();
            string yeniAd = txtyenipersonelad.Text;

            if (string.IsNullOrEmpty(yeniAd))
            {
                MessageBox.Show("Yeni personel adı boş olamaz.");
                return;
            }

            string updateQuery = "UPDATE PERSONELLER SET AD = @YeniAd WHERE AD = @EskiAd";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@YeniAd", yeniAd);
                    command.Parameters.AddWithValue("@EskiAd", eskiAd);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        VerileriGuncelle();
                        ComboboxYenile();
                        MessageBox.Show("Personel güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işlemi başarısız oldu. Seçili personel bulunamadı.");
                    }
                }
            }
        }


    }
}