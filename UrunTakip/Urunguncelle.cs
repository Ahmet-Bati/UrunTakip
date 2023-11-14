using Npgsql;
using System;
using System.Windows.Forms;

namespace UrunTakip
{
    public partial class Urunguncelle : Form
    {
        public string iUrunad, iBarkod, iDolaralis, iDolarsatis, iUrunAdeti, gonderilenid;

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

        private void Urunguncelle_Load(object sender, EventArgs e)
        {
            rjTextBox1.Texts = iUrunad;
            rjTextBox2.Texts = iBarkod;
            rjTextBox3.Texts = iDolaralis;
            rjTextBox4.Texts = iDolarsatis;
            rjTextBox5.Texts = iUrunAdeti;
        }
        private string _hedefString = BaglantiInfo.PostConnectionString;
        public Urunguncelle()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {


            string sorgu = ($"update urunler set barkod = '{rjTextBox2.Texts}', urunadi = '{rjTextBox1.Texts}', alisdolar = '{rjTextBox3.Texts.Replace(",", ".")}', satisdolar = '{rjTextBox4.Texts.Replace(",", ".")}', urunstok = '{rjTextBox5.Texts}', alistarihi = '{dateTimePicker1.Value.ToString()}' where urunid = '{gonderilenid}'");



            using (NpgsqlConnection postgreConnection = new NpgsqlConnection(_hedefString))
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
                        MessageBox.Show("Ürün Güncellendi!");
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



}

