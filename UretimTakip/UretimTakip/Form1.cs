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

namespace UretimTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string conString = "Server=DESKTOP-GI10KRJ\\SQLEXPRESS;Database=ROTA2017;Uid=sa;Password=sapass;";
        SqlConnection baglanti = new SqlConnection(conString);




        private void Form1_Load(object sender, EventArgs e)
        {
            SiparisGetir();
            SiparisGetir1();
            SiparisGetir2();

        }

        private void SiparisGetir()
        {
        
            baglanti.Open();
            string kayit = "SELECT * from dbo.DN_SiparisIzleme";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        private void SiparisGetir1()
        {

            baglanti.Open();
            string kayit = "SELECT * from dbo.DN_SiparisIzleme";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();


        }

        private void SiparisGetir2()
        {

            baglanti.Open();
            string kayit = "SELECT * from dbo.DN_SiparisIzleme";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            baglanti.Close();


        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
