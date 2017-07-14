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
        static string conString = "Server=NETCOLLEC\\SQLEXPRESS;Database=ROTA2017;Uid=sa;Password=sapass;";
        SqlConnection baglanti = new SqlConnection(conString);




        private void Form1_Load(object sender, EventArgs e)
        {
            SiparisGetir();
            UretimFisGetir();
            FaturaGetir();
           

        }

        private void SiparisGetir()
        {
        
            baglanti.Open();

         
    
            
            SqlCommand komut = new SqlCommand("dbo.NCB_URT_SIPARIS", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSiparis.DataSource = dt;
            baglanti.Close();


        }

        private void UretimFisGetir() {

            baglanti.Open();




            SqlCommand komut = new SqlCommand("dbo.NCB_URT_KAYIT", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUretim.DataSource = dt;
            baglanti.Close();


        }

        private void FaturaGetir() {
            baglanti.Open();




            SqlCommand komut = new SqlCommand("dbo.NCB_URT_FAT", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFatura.DataSource = dt;
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
