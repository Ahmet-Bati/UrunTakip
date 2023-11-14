using Npgsql;
using System;
using System.Windows.Forms;

namespace UrunTakip
{
    public partial class urunekle : Form
    {
        private string _hedefString = BaglantiInfo.PostConnectionString;

        public urunekle()
        {
            InitializeComponent();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            label7.Text = "";

            string sorgu = ($"INSERT into urunler(barkod,urunadi,alisdolar,satisdolar,urunstok,alistarihi) values('{rjTextBox2.Texts}','{rjTextBox1.Texts}',{rjTextBox3.Texts.Replace(',', '.')},{rjTextBox4.Texts.Replace(',', '.')},{rjTextBox5.Texts},'{dateTimePicker1.Value.ToString()}')");



            using (NpgsqlConnection postgreConnection = new NpgsqlConnection(_hedefString))
            {
                if (Varmi(rjTextBox2.Texts) != 0)
                {
                    MessageBox.Show("Aynı Barkodla İki Ürün Girilemez... \n Lütfen Barkodunuzu Kontrol Ediniz...", "Hata! ");
                    rjTextBox2.Texts = "";

                }
                else
                {
                    if (string.IsNullOrEmpty(rjTextBox2.Texts) || string.IsNullOrEmpty(rjTextBox1.Texts))
                    {
                        MessageBox.Show("Tüm Boşlukları Eksiksiz Doldurunuz...", "Hata! ");
                        return;
                    }
                    else
                    {
                        try
                        {
                            postgreConnection.Open();
                            var insertCommand = new NpgsqlCommand($"{sorgu}", postgreConnection);
                            insertCommand.ExecuteNonQuery();
                            postgreConnection.Close();
                            label7.Text = rjTextBox1.Texts + " Eklendi";
                            temizle();


                        }
                        catch
                        {
                            MessageBox.Show("Tüm Boşlukları Eksiksiz Doldurunuz...", "Hata! ");
                            return;
                        }
                    }
                }
            }
        }
        public int Varmi(string aranan)
        {
            string sorgu = ($"select * from urunler where barkod='{aranan}'");
            int sonuc;


            using (NpgsqlConnection postgreConnection = new NpgsqlConnection(_hedefString))
            {

                postgreConnection.Open();
                var insertCommand = new NpgsqlCommand($"{sorgu}", postgreConnection);
                insertCommand.ExecuteNonQuery();
                sonuc = Convert.ToInt32(insertCommand.ExecuteScalar());

                postgreConnection.Close();
                return sonuc;


            }

        }
        private void temizle()
        {
            rjTextBox1.Texts = "";
            rjTextBox2.Texts = "";
            rjTextBox3.Texts = "";
            rjTextBox4.Texts = "";
            rjTextBox5.Texts = "";


        }

        private void urunekle_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';
        }

        private void rjTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';
        }

        private void rjTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
