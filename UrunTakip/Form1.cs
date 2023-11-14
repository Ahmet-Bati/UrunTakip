using Npgsql;
using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml;
using UrunTakip.Extentions;
using UrunTakip.Services;

namespace UrunTakip
{
    public partial class Form1 : Form
    {
        private string _hedefString = BaglantiInfo.PostConnectionString;
        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            PostgreSqlLoadData();
            DovizGoster();
            rjDatePicker1.Text = DateTime.Now.ToString();
            DovizGoster();



        }
        private void PostgreSqlLoadData()
        {

            try
            {
                NpgsqlConnection postcon = new NpgsqlConnection(_hedefString);

                string sorgu = ("SELECT * FROM urunler order by urunid ASC");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, _hedefString);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvUrun.DataSource = ds.Tables[0].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            PostgreSqlLoadData();
        }


        urunekle f2;
        private void button1_Click_1(object sender, EventArgs e)
        {


            if (f2 == null || f2.IsDisposed)
            {
                f2 = new urunekle();
                f2.Show();
                f2.FormClosed += F2_FormClosed;
            }

        }

        Urunguncelle f4;
        private void button2_Click_1(object sender, EventArgs e)
        {

            if (f4 == null || f4.IsDisposed)
            {
                f4 = new Urunguncelle();
                f4.iUrunad = dgvUrun.CurrentRow.Cells[2].Value.ToString();
                f4.iBarkod = dgvUrun.CurrentRow.Cells[1].Value.ToString();
                f4.iDolaralis = dgvUrun.CurrentRow.Cells[3].Value.ToString();
                f4.iDolarsatis = dgvUrun.CurrentRow.Cells[4].Value.ToString();
                f4.iUrunAdeti = dgvUrun.CurrentRow.Cells[5].Value.ToString();
                f4.gonderilenid = dgvUrun.CurrentRow.Cells[0].Value.ToString();
                f4.Show();
                f4.FormClosed += F2_FormClosed;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            string gelenid = dgvUrun.CurrentRow.Cells[0].Value.ToString();
            string sorgu = ($"delete from urunler where urunid='{gelenid}'");
            DialogResult result1 = MessageBox.Show("Ürün Silinecek Emin misin?",
"Ürünü Sil ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Ürün Silindi!");
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
            if (textBox1.Text != "")
            {
                dgvUrun.DataSource = 0;
                NpgsqlConnection postcon = new NpgsqlConnection(_hedefString);
                string sorgu = "SELECT * FROM urunler WHERE urunadi LIKE '%" + textBox1.Text + "%'";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu, _hedefString);
                DataSet ds1 = new DataSet();
                da2.Fill(ds1);
                dgvUrun.DataSource = ds1.Tables[0];
            }
            else
            {
                PostgreSqlLoadData();

            }
            textBox1.Text = string.Empty;
        }
        public decimal toplamTldolar = 0;
        private void toplamtutar()
        {
            var kur = DolarService.GuncelKurGetir();
            //Sütun değerlerini toplama
            toplamTldolar = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplamTldolar += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            toplamTldolar = Math.Round(toplamTldolar, 1);
            kur = Math.Round(kur, 1);

            label6.Text = toplamTldolar.ToString() + " Dolar - " + (toplamTldolar * kur).ToString() + " TL";
        }
        private void listProducts()
        {
            var text = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                if (text.Contains("\r\n"))
                {
                    text = text.Replace("\r\n", string.Empty);
                }
                dgvUrun.DataSource = 0;
                using (NpgsqlConnection postcon = new NpgsqlConnection(_hedefString))
                {
                    if (postcon.State == ConnectionState.Closed)
                    {
                        postcon.Open();
                    }
                    string sorgu = $"SELECT * FROM urunler WHERE barkod='{textBox1.Text}'";
                    NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu, _hedefString);
                    DataSet ds1 = new DataSet();
                    da2.Fill(ds1);
                    dgvUrun.DataSource = ds1.Tables[0];

                    postcon.Close();

                }
                addToCart();
                toplamtutar();
                textBox1.Clear();
            }
            else
            {
                PostgreSqlLoadData();

            }
        }

        private void addToCart()
        {

            using (NpgsqlConnection postcon = new NpgsqlConnection(_hedefString))
            {
                if (postcon.State == ConnectionState.Closed)
                {
                    postcon.Open();
                }
                string sorgu = $"SELECT * FROM urunler WHERE barkod='{textBox1.Text}'";
                var cmd = new NpgsqlCommand(sorgu, postcon);
                var reader = cmd.ExecuteReader();
                int id = default;
                string urunAdi = string.Empty;
                string barkod = string.Empty;
                decimal fiyat = default;
                decimal alisdolar = default;
                int urunStok = default;

                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                    barkod = reader.GetString(1);
                    urunAdi = reader.GetString(2);
                    alisdolar = reader.GetDecimal(3);
                    fiyat = reader.GetDecimal(4);
                    urunStok = reader.GetInt32(5);

                }
                var sepetteUrunVarmi = false;
                var sepettekiUrunAdeti = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && (int)row.Cells[0].Value == id)
                    {
                        sepettekiUrunAdeti += 1;
                        sepetteUrunVarmi = true;
                    }
                }
                if (sepetteUrunVarmi && sepettekiUrunAdeti >= urunStok)
                {
                    MessageBox.Show("Stokta Ürün Kalmadı..");
                    postcon.Close();
                    return;
                }
                if (urunStok > 0)
                {
                    if (id != default)
                    {
                        dataGridView1.Rows.Add(id, barkod, urunAdi, alisdolar, fiyat);
                    }
                }
                else
                {
                    MessageBox.Show("Stokta Ürün Yok..");
                }
                postcon.Close();
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            listProducts();
        }


        public decimal dolarKuru;
        public void DovizGoster()
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true)
            {

                try
                {
                    XmlDocument xmlVerisi = new XmlDocument();
                    xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                    dolarKuru = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));


                    var kur = DolarService.GuncelKurGetir();
                    kur = Math.Round(kur, 2);
                    lblDolar.Text = kur.ToString();

                    var veriVarMı = DolarService.VeriVarMı();
                    if (veriVarMı)
                    {
                        using (NpgsqlConnection postgreConnection = new NpgsqlConnection(_hedefString))
                        {
                            try
                            {
                                DateTime currentDateTime = DateTime.Now;
                                string formattedDateTime = currentDateTime.ToString("dd/MM/yyyy");

                                string yenidolar = dolarKuru.ToString();

                                string sorgu1 = ($"Update doviz set dolar={yenidolar.Replace(',', '.')},dolarkurtarihi='{formattedDateTime}'");

                                postgreConnection.Open();
                                var insertCommand = new NpgsqlCommand($"{sorgu1}", postgreConnection);
                                insertCommand.ExecuteNonQuery();
                                postgreConnection.Close();
                            }
                            catch
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        using (NpgsqlConnection postgreConnection = new NpgsqlConnection(_hedefString))
                        {
                            try
                            {
                                DateTime currentDateTime = DateTime.Now;
                                string formattedDateTime = currentDateTime.ToString("dd/MM/yyyy");

                                string yenidolar = dolarKuru.ToString();

                                string sorgu1 = ($"INSERT into doviz(dolar,dolarkurtarihi) values('{yenidolar.Replace(',', '.')}','{formattedDateTime}')");

                                postgreConnection.Open();
                                var insertCommand = new NpgsqlCommand($"{sorgu1}", postgreConnection);
                                insertCommand.ExecuteNonQuery();
                                postgreConnection.Close();
                            }
                            catch
                            {
                                return;
                            }
                        }
                    }


                }
                catch (XmlException xml)
                {
                    MessageBox.Show(xml.ToString());
                }




            }
            else
            {
                MessageBox.Show("İnternet Olmadığı için En son Güncel Kur Baz Alınacaktır...", "Dikkat !");


                var kur = DolarService.GuncelKurGetir();
                dolarKuru = kur;
                lblDolar.Text = kur.ToString();
            }
        }
        private void add(int id, string barkod, string urunAdi, decimal alisDolar, decimal satis, int stok)
        {
            using (NpgsqlConnection postgreConnection = new NpgsqlConnection(_hedefString))
            {
                try
                {
                    if (postgreConnection.State == ConnectionState.Closed)
                    {
                        postgreConnection.Open();
                    }

                    DateTime currentDateTime = DateTime.Now;
                    string formattedDateTime = currentDateTime.ToString("dd/MM/yyyy");
                    string satisTl = (dolarKuru * satis).ToStringForDatabase();

                    string insertquery = $"INSERT into satilanurunler(barkod,urunadi,alisdolar,satisdolar,satistl,satistarihi) values('{barkod}','{urunAdi}',{alisDolar.ToStringForDatabase().Replace(",", ".")},{satis.ToStringForDatabase().Replace(",", ".")},{satisTl},'{formattedDateTime}')";
                    var cmd2 = new NpgsqlCommand(insertquery, postgreConnection);
                    cmd2.ExecuteNonQuery();
                    string updatequery = $"update urunler set urunstok = {stok - 1} where urunid={id}";
                    var cmd3 = new NpgsqlCommand(updatequery, postgreConnection);
                    cmd3.ExecuteNonQuery();
                    postgreConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (postgreConnection.State == ConnectionState.Open)
                    {
                        postgreConnection.Close();
                    }
                }
                finally
                {
                    if (postgreConnection.State == ConnectionState.Open)
                    {
                        postgreConnection.Close();
                    }
                }
            }
        }
        private void rjButton6_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                using (NpgsqlConnection postgreConnection = new NpgsqlConnection(_hedefString))
                {
                    try
                    {
                        if (postgreConnection.State == ConnectionState.Closed)
                        {
                            postgreConnection.Open();
                        }

                        if (row.Cells[0].Value != null)
                        {
                            var id = int.Parse(row.Cells[0]?.Value.ToString());

                            string sorgu = $"SELECT * FROM urunler WHERE urunid={id}";
                            var cmd = new NpgsqlCommand(sorgu, postgreConnection);
                            var reader = cmd.ExecuteReader();
                            int stok = default;
                            if (reader.Read())
                            {
                                stok = reader.GetInt32(5);
                            }
                            if (stok > 0)
                            {

                                var barkod = row.Cells[1]?.Value.ToString();
                                var urunadi = row.Cells[2]?.Value.ToString();
                                var alisDolar = decimal.Parse(row.Cells[3]?.Value.ToString());
                                var satisDolar = decimal.Parse(row.Cells[4]?.Value.ToString());
                                postgreConnection.Close();
                                add(id, barkod, urunadi, alisDolar, satisDolar, stok);


                            }
                            else
                            {

                            }


                        }
                        else
                        {

                        }

                        postgreConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        if (postgreConnection.State == ConnectionState.Open)
                        {
                            postgreConnection.Close();
                        }
                    }
                    finally
                    {
                        if (postgreConnection.State == ConnectionState.Open)
                        {
                            postgreConnection.Close();
                        }
                    }

                }
            }
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {
                MessageBox.Show("Ürünler Satıldı");
            }
            dataGridView1.Rows.Clear();
            toplamTldolar = 0;
            label6.Text = "";
            PostgreSqlLoadData();


        }



        satilanurunler f3;
        private void rjButton5_Click(object sender, EventArgs e)
        {

            if (f3 == null || f3.IsDisposed)
            {
                f3 = new satilanurunler();
                f3.Show();
                f3.FormClosed += F2_FormClosed;
            }
        }



        private void dgvUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal d = decimal.Parse(dgvUrun.CurrentRow.Cells[4].Value.ToString());

                decimal sonuc = (dolarKuru * d);
                sonuc = Math.Round(sonuc, 2);
                label5.Text = sonuc.ToString();

            }
            catch
            {
                MessageBox.Show("Satış Fiyatı Olan Ürünleri Seçiniz...", "Hata! ");

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listProducts();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void btnRemoveToCart_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("çıkarılacak ürünü saçiniz.");
                return;
            }
            foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
            {
                if (!selectedRow.IsNewRow)
                {
                    dataGridView1.Rows.Remove(selectedRow);
                }

            }
            toplamtutar();


        }


    }
}
