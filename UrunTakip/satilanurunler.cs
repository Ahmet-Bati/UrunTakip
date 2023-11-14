using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using UrunTakip.Services;

namespace UrunTakip
{
    public partial class satilanurunler : Form
    {
        private string _hedefString = BaglantiInfo.PostConnectionString;

        public satilanurunler()
        {
            InitializeComponent();
        }

        private void satilanurunler_Load(object sender, EventArgs e)
        {
            PostgreSqlLoadData();

            rjDatePicker1.Text = DateTime.Now.ToString();
            rjDatePicker2.Text = DateTime.Now.ToString();
        }

        private void PostgreSqlLoadData()
        {

            try
            {
                NpgsqlConnection postcon = new NpgsqlConnection(_hedefString);

                string sorgu = ("SELECT * FROM satilanurunler order by satistarihi ASC");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, _hedefString);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DgvSatilan.DataSource = ds.Tables[0].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {

            string gelenid = DgvSatilan.CurrentRow.Cells[0].Value.ToString();
            string sorgu = ($"delete from satilanurunler where id='{gelenid}'");
            DialogResult result1 = MessageBox.Show("Kayıt Silinecek Emin misin?",
"Kaydı Sil ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result1 == DialogResult.Yes)
            {
                using (NpgsqlConnection postgreConnection = new NpgsqlConnection(_hedefString))
                {
                    try
                    {
                        postgreConnection.Open();
                        var insertCommand = new NpgsqlCommand($"{sorgu}", postgreConnection);
                        insertCommand.ExecuteNonQuery();
                        postgreConnection.Close();
                        MessageBox.Show("Kayıt  Silindi!");
                        PostgreSqlLoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata! " + ex.ToString());
                        return;
                    }
                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string sTarih = rjDatePicker1.Value.Date.ToString("dd/MM/yyyy");


            try
            {
                NpgsqlConnection postcon = new NpgsqlConnection(_hedefString);

                string sorgu = ($"SELECT * FROM satilanurunler where satistarihi='{sTarih}' order by satistarihi ASC");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, _hedefString);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DgvSatilan.DataSource = ds.Tables[0].DefaultView;

                decimal alisdolar = 0;
                decimal satisdolar = 0;

                decimal sonuc = 0;

                for (int i = 0; i < DgvSatilan.Rows.Count; ++i)
                {
                    alisdolar = Convert.ToDecimal(DgvSatilan.Rows[i].Cells[3].Value);

                    satisdolar = Convert.ToDecimal(DgvSatilan.Rows[i].Cells[4].Value);
                    sonuc += (satisdolar - alisdolar);

                }
                var kur = DolarService.GuncelKurGetir();
                kur = Math.Round(kur, 1);
                sonuc = Math.Round(sonuc, 1);
                label2.Text = sonuc.ToString() + " Dolar($) ";
                label3.Text = (sonuc * kur).ToString() + " Tl(₺) ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            PostgreSqlLoadData();
            label2.Text = "";
            label3.Text = "";

            decimal alisdolar = 0;
            decimal satisdolar = 0;

            decimal sonuc = 0;

            for (int i = 0; i < DgvSatilan.Rows.Count; ++i)
            {
                alisdolar = Convert.ToDecimal(DgvSatilan.Rows[i].Cells[3].Value);

                satisdolar = Convert.ToDecimal(DgvSatilan.Rows[i].Cells[4].Value);
                sonuc += (satisdolar - alisdolar);

            }
            var kur = DolarService.GuncelKurGetir();
            kur = Math.Round(kur, 1);
            sonuc = Math.Round(sonuc, 1);
            label2.Text = sonuc.ToString() + " Dolar($) ";
            label3.Text = (sonuc * kur).ToString() + " Tl(₺) ";
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            string sTarih = rjDatePicker1.Value.Date.ToString("dd/MM/yyyy");
            string sTarih2 = rjDatePicker2.Value.Date.ToString("dd/MM/yyyy");


            try
            {
                NpgsqlConnection postcon = new NpgsqlConnection(_hedefString);

                string sorgu = ($"SELECT * FROM satilanurunler where satistarihi between '{sTarih}' and '{sTarih2}' order by satistarihi ASC");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, _hedefString);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DgvSatilan.DataSource = ds.Tables[0].DefaultView;

                decimal alisdolar = 0;
                decimal satisdolar = 0;

                decimal sonuc = 0;

                for (int i = 0; i < DgvSatilan.Rows.Count; ++i)
                {
                    alisdolar = Convert.ToDecimal(DgvSatilan.Rows[i].Cells[3].Value);

                    satisdolar = Convert.ToDecimal(DgvSatilan.Rows[i].Cells[4].Value);
                    sonuc += (satisdolar - alisdolar);

                }
                var kur = DolarService.GuncelKurGetir();
                kur = Math.Round(kur, 1);
                sonuc = Math.Round(sonuc, 1);
                label2.Text = sonuc.ToString() + " Dolar($) ";
                label3.Text = (sonuc * kur).ToString() + " Tl(₺) ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
