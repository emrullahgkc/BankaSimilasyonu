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
namespace BankaHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sqlbaglantisi conn = new Sqlbaglantisi();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("select * From tbl_kullanici  where tc=@p1 and  sifre=@p2",conn.baglanti());
            komut.Parameters.AddWithValue("@p1",mtxttc.Text);
            komut.Parameters.AddWithValue("@p2",txtpassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
           
              Frm_userdetail fr = new Frm_userdetail();
                fr.tc = mtxttc.Text;
             fr.Show();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ...");
            }
          
        }

        private void lnkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addregister fr = new addregister();
            fr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
