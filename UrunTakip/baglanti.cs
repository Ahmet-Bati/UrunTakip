using Npgsql;
using System;
using System.Configuration;
using System.Windows.Forms;
using UrunTakip;

namespace WindowsFormsDeneme
{
    public partial class baglanti : Form
    {
        public baglanti()
        {
            InitializeComponent();
        }
        public static bool PostgresqlTruemu { get; set; }





        public void CheckPostgresqlConnection()
        {

            PostgresqlTruemu = false;
            string postgreConnectionString = ConfigurationManager.ConnectionStrings["PostgreConnection"].ConnectionString;

            using (var conn = new NpgsqlConnection(postgreConnectionString))
            {
                try
                {
                    conn.Open();
                    BaglantiInfo.PostConnectionString = postgreConnectionString;
                    PostgresqlTruemu = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Veritabanına Bağlanamadı...");
                }
            }
        }


        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }



        private void baglanti_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CheckPostgresqlConnection();


        }
        int zaman = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 15;
            progressBar1.Value = zaman;
            zaman++;
            if (zaman > 100)
            {
                timer1.Stop();

                if (PostgresqlTruemu == true)
                {
                    this.Hide();
                    Form1 f2 = new Form1();
                    f2.Show();
                    f2.FormClosed += F2_FormClosed;
                }
                else
                {
                    MessageBox.Show("Bağlantılarda hata var");
                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (PostgresqlTruemu == true)
            {
                this.Hide();
                Form1 f2 = new Form1();
                f2.Show();
                f2.FormClosed += F2_FormClosed;
            }
            else
            {
                MessageBox.Show("Bağlantılarda hata var");
            }
        }


    }
}
