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
    public partial class addregister : Form
    {
        public addregister()
        {
            InitializeComponent();
        }
        Sqlbaglantisi conn = new Sqlbaglantisi();
        BankaHesabEntitiess db = new BankaHesabEntitiess();
        tbl_kullanici user = new tbl_kullanici();
        tbl_kul_bnk kbank = new tbl_kul_bnk();       

        

        private void btnregister_Click(object sender, EventArgs e)
        {
        
            var bank = byte.Parse(cmbbnk.SelectedValue.ToString());
            var tcKontrol = db.tbl_kullanici.Where(p => p.tc == mtxttc.Text).FirstOrDefault();
            if (tcKontrol != null)
            {
                var bankKontrol = db.tbl_kul_bnk.Where(p => p.kullaniciid == tcKontrol.id && p.bankaid == bank).FirstOrDefault();
                if (bankKontrol != null)
                {
                    MessageBox.Show("Bu Bankada Hesabınız Mevcut");
                    return;
                }
            }
            Random rdm = new Random();
            var hesapno = rdm.Next(10000, 100000);
            var iban = rdm.Next(1000000, 10000000);
            if (txtname.Text != "" && txtpassword.Text != "" && txtsname.Text != "" && mtxtphone.Text != "(   )    -" && mtxttc.Text != "")
            {
                if (tcKontrol == null)
                {
                    user.ad = txtname.Text;
                    user.soyad = txtsname.Text;
                    user.telefon = mtxtphone.Text;
                    user.sifre = txtpassword.Text;
                    user.tc = mtxttc.Text;
                    kbank.kullaniciid = user.id;
                    db.tbl_kullanici.Add(user);
                }                else                {
                    kbank.kullaniciid = tcKontrol.id;
                }
                kbank.hesapno = hesapno.ToString();
                kbank.iban = iban.ToString();
                kbank.bankaid = byte.Parse(cmbbnk.SelectedValue.ToString());
                db.tbl_kul_bnk.Add(kbank);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi..");
            }            else            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Doldurunuz.");
            }
        }
        private void addregister_Load(object sender, EventArgs e)
        {
            var ch = db.tbl_Banka.ToList();
            cmbbnk.ValueMember = "id";
            cmbbnk.DisplayMember = "bankaad";
            cmbbnk.DataSource = ch;
        }
    }
}
